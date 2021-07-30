/*************************************************************
'Author         :tuanhm
'Business Layer Name        : TM_SALE
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
    public partial class BUS_TM_SALE
    {
        #region "Instances"
        private static BUS_TM_SALE _instance;

        protected BUS_TM_SALE()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static BUS_TM_SALE Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new BUS_TM_SALE();
                    }
                }
            }
            return _instance;
        }
        #endregion


        public TM_SALEInfo TM_SALE_Insert(TM_SALEInfo objInfo)
        {
        DAL_TM_SALE.Instance().TM_SALE_Insert(objInfo);
            return objInfo;
        }
        public List<TM_SALEInfo> TM_SALE_SelectAll()
        {
            List<TM_SALEInfo> list = dbAssistant.DataReaderMapToList<TM_SALEInfo>(DAL_TM_SALE.Instance().TM_SALE_SelectAll());
            return list;
        }
        public int TM_SALE_Delete(Double? ID)
        {
            return DAL_TM_SALE.Instance().TM_SALE_Delete(ID);
        }
        public int TM_SALE_Update(TM_SALEInfo objInfo)
        {
            return DAL_TM_SALE.Instance().TM_SALE_Update(objInfo);
        }
        public TM_SALEInfo TM_SALE_SelectById(Double? ID)
        {
          return dbAssistant.DataReaderMapToObject<TM_SALEInfo>(DAL_TM_SALE.Instance().TM_SALE_SelectById(ID));
        }
        }
        }
