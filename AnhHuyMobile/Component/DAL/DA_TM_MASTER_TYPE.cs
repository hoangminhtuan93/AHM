/*************************************************************
'Author         :tuanhm
'Data Access Layer Name        : TM_MASTER_TYPE
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
    public partial class DAL_TM_MASTER_TYPE
    {
        private static DAL_TM_MASTER_TYPE _instance;

        protected DAL_TM_MASTER_TYPE()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static DAL_TM_MASTER_TYPE Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new DAL_TM_MASTER_TYPE();
                    }
                }
            }
            return _instance;
        }
        public object TM_MASTER_TYPE_Insert(TM_MASTER_TYPEInfo objInfo)
        {
            return dbConnection.ExecuteScalar("TM_MASTER_TYPE_Insert", dbAssistant.SetvalueParameter(objInfo));
        }
        public int TM_MASTER_TYPE_Update(TM_MASTER_TYPEInfo objInfo)
        {
            return dbConnection.ExecuteNonQuery("TM_MASTER_TYPE_Update",dbAssistant.SetvalueParameter(objInfo));
        }
        public int TM_MASTER_TYPE_Delete(int? ID)
        {
            return dbConnection.ExecuteNonQuery("TM_MASTER_TYPE_Delete", dbAssistant.SetvalueParameter(ID,"ID"));
        }
        public IDataReader TM_MASTER_TYPE_SelectAll()
        {
            return dbConnection.ExecuteReader("TM_MASTER_TYPE_SelectAll", null);
        }
        public IDataReader TM_MASTER_TYPE_SelectById(int? ID)
        {
            return dbConnection.ExecuteReader("TM_MASTER_TYPE_SelectById", dbAssistant.SetvalueParameter(ID,"ID"));
        }

    }
}
