/*************************************************************
'Author         :tuanhm
'Business Layer Name        : TM_MASTER_GOODS
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
    public partial class BUS_TM_MASTER_GOODS
    {
        #region "Instances"
        private static BUS_TM_MASTER_GOODS _instance;

        protected BUS_TM_MASTER_GOODS()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static BUS_TM_MASTER_GOODS Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new BUS_TM_MASTER_GOODS();
                    }
                }
            }
            return _instance;
        }
        #endregion


        public TM_MASTER_GOODSInfo TM_MASTER_GOODS_Insert(TM_MASTER_GOODSInfo objInfo)
        {
        DAL_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_Insert(objInfo);
            return objInfo;
        }
        public List<TM_MASTER_GOODSInfo> TM_MASTER_GOODS_SelectAll()
        {
            List<TM_MASTER_GOODSInfo> list = dbAssistant.DataReaderMapToList<TM_MASTER_GOODSInfo>(DAL_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_SelectAll());
            return list;
        }
        public int TM_MASTER_GOODS_Delete(Double? ID)
        {
            return DAL_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_Delete(ID);
        }
        public int TM_MASTER_GOODS_Update(TM_MASTER_GOODSInfo objInfo)
        {
            return DAL_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_Update(objInfo);
        }
        public TM_MASTER_GOODSInfo TM_MASTER_GOODS_SelectById(Double? ID)
        {
          return dbAssistant.DataReaderMapToObject<TM_MASTER_GOODSInfo>(DAL_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_SelectById(ID));
        }
        }
        }
