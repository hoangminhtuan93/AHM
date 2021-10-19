/*************************************************************
'Author         :tuanhm
'Business Layer Name        : TM_SALEPartialClass
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
    public partial class TM_SALEInfo
    {
        // Add custom code here
    }
    public partial class BUS_TM_SALE
    {
        // Add custom code here

        public DataTable TM_SALE_Select_dgv()
        {
            return dbConnection.ExecuteDataset("TM_SALE_Select_dgv", dbAssistant.SetvalueParameter()).Tables[0];
        }
        public DataTable TM_SALE_SelectBySUM(DateTime DAT_DATE)
        {
            return dbConnection.ExecuteDataset("TM_SALE_SelectBySUM", dbAssistant.SetvalueParameter(DAT_DATE, "DAT_DATE")).Tables[0];
        }
        public DataTable TM_SALE_SelectBySUM_in(DateTime DAT_DATE)
        {
            return dbConnection.ExecuteDataset("TM_SALE_SelectBySUM_in", dbAssistant.SetvalueParameter(DAT_DATE, "DAT_DATE")).Tables[0];
        }
        public DataTable TM_SALE_SelectBySUM_get(DateTime DAT_DATE)
        {
            return dbConnection.ExecuteDataset("TM_SALE_SelectBySUM_get", dbAssistant.SetvalueParameter(DAT_DATE, "DAT_DATE")).Tables[0];
        }
        public DataTable TM_SALE_SelectByDate(DateTime DAT_DATE)
        {
            return dbConnection.ExecuteDataset("TM_SALE_SelectByDate", dbAssistant.SetvalueParameter(DAT_DATE, "DAT_DATE")).Tables[0];
        }
        public DataTable TM_SALE_check_type(int ID_TYPE)
        {
            return dbConnection.ExecuteDataset("TM_SALE_check_type", dbAssistant.SetvalueParameter(ID_TYPE, "ID_TYPE")).Tables[0];
        }
        public DataTable TM_SALE_check_good(int ID_GOODS)
        {
            return dbConnection.ExecuteDataset("TM_SALE_check_good", dbAssistant.SetvalueParameter(ID_GOODS, "ID_GOODS")).Tables[0];
        }
        public DataTable TM_SALE_Select_rev_by_date(DateTime DAT_FROM, DateTime DAT_TO)
        {
            return dbConnection.ExecuteDataset("TM_SALE_Select_rev_by_date", dbAssistant.SetvalueParameter(DAT_FROM, "DAT_FROM", DAT_TO, "DAT_TO")).Tables[0];
        }

        public DataTable TM_SALE_Select_rev_by_cus(string text)
        {
            return dbConnection.ExecuteDataset("TM_SALE_Select_rev_by_cus", dbAssistant.SetvalueParameter(text, "text")).Tables[0];
        }
        public DataSet TM_SALE_Select_by_date(DateTime DAT_FROM, DateTime DAT_TO)
        {
            return dbConnection.ExecuteDataset("TM_SALE_Select_by_date", dbAssistant.SetvalueParameter(DAT_FROM, "DAT_FROM", DAT_TO, "DAT_TO"));
        }
        //TM_SALE_SelectBySUM_range_date
        public DataSet TM_SALE_SelectBySUM_range_date(DateTime DAT_FROM, DateTime DAT_TO)
        {
            return dbConnection.ExecuteDataset("TM_SALE_SelectBySUM_range_date", dbAssistant.SetvalueParameter(DAT_FROM, "DAT_FROM", DAT_TO, "DAT_TO"));
        }
    }
    public partial class DAL_TM_SALE
    {
        // Add custom code here
    }
}

