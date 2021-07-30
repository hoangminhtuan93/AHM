/*************************************************************
'Author         :tuanhm
'Business Layer Name        : TM_MASTER_TYPE
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
    public partial class BUS_TM_MASTER_TYPE
    {
        #region "Instances"
        private static BUS_TM_MASTER_TYPE _instance;

        protected BUS_TM_MASTER_TYPE()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static BUS_TM_MASTER_TYPE Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new BUS_TM_MASTER_TYPE();
                    }
                }
            }
            return _instance;
        }
        #endregion


        public TM_MASTER_TYPEInfo TM_MASTER_TYPE_Insert(TM_MASTER_TYPEInfo objInfo)
        {
        DAL_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Insert(objInfo);
            return objInfo;
        }
        public List<TM_MASTER_TYPEInfo> TM_MASTER_TYPE_SelectAll()
        {
            List<TM_MASTER_TYPEInfo> list = dbAssistant.DataReaderMapToList<TM_MASTER_TYPEInfo>(DAL_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_SelectAll());
            return list;
        }
        public int TM_MASTER_TYPE_Delete(int? ID)
        {
            return DAL_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Delete(ID);
        }
        public int TM_MASTER_TYPE_Update(TM_MASTER_TYPEInfo objInfo)
        {
            return DAL_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Update(objInfo);
        }
        public TM_MASTER_TYPEInfo TM_MASTER_TYPE_SelectById(int? ID)
        {
          return dbAssistant.DataReaderMapToObject<TM_MASTER_TYPEInfo>(DAL_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_SelectById(ID));
        }
        }
        }
