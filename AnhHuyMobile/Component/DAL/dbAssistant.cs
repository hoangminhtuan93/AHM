/*************************************************************
'Author         :tuanhm
'Class Name        : dbAssitance
'Created Date   :2020-07-27 12:41:51 PM
'Description    : Was created by GenCode3TierCSharp (maovu)
'History        : 
*************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Net.Mail;

using System.Resources;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;

namespace AnhHuyMobile
{

    public class dbAssistant
    {
        private static Dictionary<Type, SqlDbType> typeMap;
        static dbAssistant()

        {
            // Lưu ý:
            // 1. Đối với byte[] thì tùy thuộc vào cơ sở dữ liệu từng người thiết kế là ứng với kiểu nào thì thay đổi cho phù hợp
            //    SqlDbType.Varbinary hoặc SqlDbType.binary hoặc SqlDbType.Image
            // ***********************************************
            typeMap = new Dictionary<Type, SqlDbType>();
            typeMap[typeof(byte[])] = SqlDbType.VarBinary;
            typeMap[typeof(string)] = SqlDbType.NVarChar;
            typeMap[typeof(char[])] = SqlDbType.NVarChar;
            typeMap[typeof(byte)] = SqlDbType.TinyInt;
            typeMap[typeof(short)] = SqlDbType.SmallInt;
            typeMap[typeof(int)] = SqlDbType.Int;
            typeMap[typeof(Int32)] = SqlDbType.Int;
            typeMap[typeof(long)] = SqlDbType.BigInt;
            typeMap[typeof(bool)] = SqlDbType.Bit;
            typeMap[typeof(DateTime)] = SqlDbType.DateTime;
            typeMap[typeof(DateTimeOffset)] = SqlDbType.DateTimeOffset;
            typeMap[typeof(decimal)] = SqlDbType.Money;
            typeMap[typeof(float)] = SqlDbType.Real;
            typeMap[typeof(double)] = SqlDbType.Float;
            typeMap[typeof(TimeSpan)] = SqlDbType.Time;
        }
        public static SqlDbType GetDbType(Type giveType)
        {

            if (typeMap.ContainsKey(giveType))
            {
                return typeMap[giveType];
            }
            throw new ArgumentException("Không hỗ Convert kiểu dữ liệu " + giveType.Name + " sang SqlDbType");
        }
        public static SqlDbType GetDbType<T>()
        {
            return GetDbType(typeof(T));
        }
        public static class MemberInfoGetting
        {
            public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
            {
                MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
                return expressionBody.Member.Name;
            }
        }
        // Convert Object to SqlParameter
        public static SqlParameter[] SetvalueParameter(params object[] _obj)
        {
            if (_obj.Length == 1)
            {
                Type t = _obj[0].GetType();
                List<SqlParameter> sqlParameter = new List<SqlParameter>();
                foreach (var property in t.GetProperties())
                {
                    SqlDbType sqlt = new SqlDbType();
                    // Cho những kiểu giá trị được phép null?
                    if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                    {
                        sqlt = GetDbType(Nullable.GetUnderlyingType(property.PropertyType));
                    }
                    else
                    {
                        sqlt = GetDbType(property.PropertyType);
                    }
                    SqlParameter parameters = new SqlParameter("@" + property.Name + "", sqlt);
                    if (property.GetValue(_obj[0], null) == null)
                    {
                        parameters.Value = DBNull.Value;
                    }
                    else
                    {
                        parameters.Value = property.GetValue(_obj[0], null);
                    }
                    sqlParameter.Add(parameters);
                }
                return sqlParameter.ToArray();
            }
            else
            {
                List<SqlParameter> sqlParameter = new List<SqlParameter>();
                bool Kieudulieu = true;
                SqlDbType sqlt = new SqlDbType();
                object Value = new object();
                foreach (object obj in _obj)
                {
                    if (Kieudulieu == true)
                    {
                        if (obj == null)
                        {
                            Value = DBNull.Value;
                        }
                        else
                        {
                            Type t = obj.GetType();
                            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                            {
                                sqlt = GetDbType(Nullable.GetUnderlyingType(t));
                            }
                            else
                            {
                                sqlt = GetDbType(t);
                            }
                            if (t.Name.Equals("Int32"))
                            {
                                if (Convert.ToInt32(obj).Equals(int.MinValue))
                                {
                                    Value = DBNull.Value;
                                }
                                else
                                {
                                    Value = obj;
                                }
                            }
                            else if (t.Name.Equals("DateTime"))
                            {
                                if (Convert.ToDateTime(obj).Equals(DateTime.MinValue))
                                {
                                    Value = DBNull.Value;
                                }
                                else
                                {
                                    Value = obj;
                                }
                            }
                            else if (t.Name.Equals("String"))
                            {
                                if (Convert.ToString(obj).Equals(String.Empty))
                                {
                                    Value = DBNull.Value;
                                }
                                else
                                {
                                    Value = obj;
                                }
                            }
                            else if (t.Name.Equals("Double"))
                            {
                                if (Convert.ToDouble(obj).Equals(Double.MinValue))
                                {
                                    Value = DBNull.Value;
                                }
                                else
                                {
                                    Value = obj;
                                }
                            }
                            else if (t.Name.Equals("Single"))
                            {
                                if (Convert.ToDecimal(obj).Equals(Double.MinValue))
                                {
                                    Value = DBNull.Value;
                                }
                                else
                                {
                                    Value = obj;
                                }
                            }
                            else
                            {
                                Value = obj;
                            }
                        }
                        Kieudulieu = false;
                    }
                    else
                    {
                        SqlParameter parameters = new SqlParameter("@" + obj.ToString() + "", sqlt);
                        parameters.Value = Value;
                        sqlParameter.Add(parameters);
                        Kieudulieu = true;
                    }
                }
                return sqlParameter.ToArray();
            }
        }
        public static string GenerateRandomString(int length)
        {
            var numArray = new byte[length];
            new RNGCryptoServiceProvider().GetBytes(numArray);
            return CleanUpBase64String(Convert.ToBase64String(numArray), length);
        }
        private static string CleanUpBase64String(string input, int maxLength)
        {
            input = input.Replace(" - ", "");
            input = input.Replace(" = ", "");
            input = input.Replace(" / ", "");
            input = input.Replace(" + ", "");
            input = input.Replace(" ", "");
            while (input.Length < maxLength)
                input = input + GenerateRandomString(maxLength);
            return input.Length <= maxLength ?
                input.ToUpper() : //In my case I want capital letters
                input.ToUpper().Substring(0, maxLength);
        }

        public static string UserLogin()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name.Replace(@"AP\", "");
        }

        public static void SendMailIT(string title, string body, int high, string[] users, string manager)
        {
            try
            {
                string[] emailManager = manager.Split(';');
                MailMessage message1 = new MailMessage("SystemEmail@brother - bivn.com.vn", users[0] + "@brothergroup.net", title, body); 
                for (int i = 0; i < users.Length; i++)
                {
                    if (i != 0)
                    {
                        message1.To.Add(users[i].ToString() + "@brothergroup.net");

                    }
                }
                if (high == 1)
                {
                    message1.Priority = MailPriority.High;
                }

            }
            catch (Exception ex)
            {
            }
        }

        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    try
                    {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                            var targetType = Nullable.GetUnderlyingType(prop.PropertyType) != null ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType;
                            prop.SetValue(obj, Convert.ChangeType(dr[prop.Name], targetType), null);
                    }
                    }
                    catch (System.IndexOutOfRangeException ex) { }
                }
                list.Add(obj);
            }
            dr.Close();
            return list;
        }
        public static T DataReaderMapToObject<T>(IDataReader dr)
        {
T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        if (!object.Equals(dr[prop.Name], DBNull.Value))
                        {
                            var targetType = Nullable.GetUnderlyingType(prop.PropertyType) != null ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType;
                            prop.SetValue(obj, Convert.ChangeType(dr[prop.Name], targetType), null);
                        }
                    }
                    catch (System.IndexOutOfRangeException ex) { }
                }
            }
            dr.Close();
            return obj;
            }
            }
            }
