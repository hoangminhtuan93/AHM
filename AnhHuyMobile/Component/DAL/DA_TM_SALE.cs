/*************************************************************
'Author         :tuanhm
'Data Access Layer Name        : TM_SALE
'Created Date   :2020-07-27 12:41:51 PM
'Description    : Was created by GenCode3TierCSharp (maovu)
'History        : 
*************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace AnhHuyMobile
{
    public partial class DAL_TM_SALE
    {
        private static DAL_TM_SALE _instance;

        protected DAL_TM_SALE()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static DAL_TM_SALE Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new DAL_TM_SALE();
                    }
                }
            }
            return _instance;
        }
        public object TM_SALE_Insert(TM_SALEInfo objInfo)
        {
            return dbConnection.ExecuteScalar("TM_SALE_Insert", dbAssistant.SetvalueParameter(objInfo));
        }
        public int TM_SALE_Update(TM_SALEInfo objInfo)
        {
            return dbConnection.ExecuteNonQuery("TM_SALE_Update",dbAssistant.SetvalueParameter(objInfo));
        }
        public int TM_SALE_Delete(Double? ID)
        {
            return dbConnection.ExecuteNonQuery("TM_SALE_Delete", dbAssistant.SetvalueParameter(ID,"ID"));
        }
        public IDataReader TM_SALE_SelectAll()
        {
            return dbConnection.ExecuteReader("TM_SALE_SelectAll", null);
        }
        public IDataReader TM_SALE_SelectById(Double? ID)
        {
            return dbConnection.ExecuteReader("TM_SALE_SelectById", dbAssistant.SetvalueParameter(ID,"ID"));
        }

    }
}
