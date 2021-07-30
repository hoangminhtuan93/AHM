/*************************************************************
'Author         :tuanhm
'Class Name        : dbConnection
'Created Date   :2020-07-27 12:41:51 PM
'Description    : Was created by GenCode3TierCSharp (maovu)
'History        : 
*************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AnhHuyMobile
{
    public class dbConnection
    {
        private static SqlDataAdapter myAdapter;
        private static SqlConnection conn;
        public static string str_user = string.Empty;
        private static SqlConnection openConnection()
        {
            if (myAdapter == null)
            {
                myAdapter = new SqlDataAdapter();
                conn = new SqlConnection("Server = " + Properties.Settings.Default.Server + "; database = " + Properties.Settings.Default.DB + "; Uid = " + Properties.Settings.Default.User + "; Pwd = " + Properties.Settings.Default.Pass);
            }
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        public static DataSet ExecuteDataset(String _store, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _store;
                myCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameter != null)
                {
                    myCommand.Parameters.AddRange(sqlParameter);
                }
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error - Query: " + _store + " Exception: " + e.Message + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return ds;
        }
        public static SqlDataReader ExecuteReader(String _store, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _store;
                myCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameter != null)
                {
                    myCommand.Parameters.AddRange(sqlParameter);
                }
                return myCommand.ExecuteReader();
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error - Query: " + _store + " Exception: " + e.Message + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
        }
        public static int ExecuteNonQuery(String _store, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _store;
                myCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameter != null)
                {
                    myCommand.Parameters.AddRange(sqlParameter);
                }
                return myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error - Query: " + _store + " Exception: " + e.Message + e.StackTrace.ToString());
                return 0;
            }
            finally
            {
            }
        }
        public static object ExecuteScalar(String _store, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _store;
                myCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameter != null)
                {
                    myCommand.Parameters.AddRange(sqlParameter);
                }
                myAdapter.InsertCommand = myCommand;
                return myCommand.ExecuteScalar();
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error - Query: " + _store + " Exception: " + e.Message + e.StackTrace.ToString());
                return 0;
            }
            finally
            {
            }
        }
        public static DataSet ExecuteDataset_text(String querry_text)
        {
            SqlCommand myCommand = new SqlCommand();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = querry_text;
                myCommand.CommandType = CommandType.Text; 
                //myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error - Query: " + querry_text + " Exception: " + e.Message + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return ds;
        }
    }
}
