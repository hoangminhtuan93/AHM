/*************************************************************
'Author         :tuanhm
'Data Access Layer Name        : TM_MASTER_GOODS
'Created Date   :2020-08-01 2:44:01 PM
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
    public partial class DAL_TM_MASTER_GOODS
    {
        private static DAL_TM_MASTER_GOODS _instance;

        protected DAL_TM_MASTER_GOODS()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static DAL_TM_MASTER_GOODS Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new DAL_TM_MASTER_GOODS();
                    }
                }
            }
            return _instance;
        }
        public object TM_MASTER_GOODS_Insert(TM_MASTER_GOODSInfo objInfo)
        {
            return dbConnection.ExecuteScalar("TM_MASTER_GOODS_Insert", dbAssistant.SetvalueParameter(objInfo));
        }
        public int TM_MASTER_GOODS_Update(TM_MASTER_GOODSInfo objInfo)
        {
            return dbConnection.ExecuteNonQuery("TM_MASTER_GOODS_Update",dbAssistant.SetvalueParameter(objInfo));
        }
        public int TM_MASTER_GOODS_Delete(Double? ID)
        {
            return dbConnection.ExecuteNonQuery("TM_MASTER_GOODS_Delete", dbAssistant.SetvalueParameter(ID,"ID"));
        }
        public IDataReader TM_MASTER_GOODS_SelectAll()
        {
            return dbConnection.ExecuteReader("TM_MASTER_GOODS_SelectAll", null);
        }
        public IDataReader TM_MASTER_GOODS_SelectById(Double? ID)
        {
            return dbConnection.ExecuteReader("TM_MASTER_GOODS_SelectById", dbAssistant.SetvalueParameter(ID,"ID"));
        }

    }
}
