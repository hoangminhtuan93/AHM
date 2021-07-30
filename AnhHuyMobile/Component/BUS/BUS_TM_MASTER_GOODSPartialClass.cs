/*************************************************************
'Author         :tuanhm
'Business Layer Name        : TM_MASTER_GOODSPartialClass
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
    public partial class TM_MASTER_GOODSInfo
    {
        // Add custom code here
    }
    public partial class BUS_TM_MASTER_GOODS
    {
        // Add custom code here 
        public DataTable TM_MASTER_GOODS_Select_dgv()
        {
            return dbConnection.ExecuteDataset("TM_MASTER_GOODS_Select_dgv", dbAssistant.SetvalueParameter()).Tables[0];
        } 
        public DataTable TM_MASTER_GOODS_SelectBy_ID_type(int ID_TYPE)
        {
            return dbConnection.ExecuteDataset("TM_MASTER_GOODS_SelectBy_ID_type", dbAssistant.SetvalueParameter(ID_TYPE, "ID_TYPE")).Tables[0];
        }
    }
    public partial class DAL_TM_MASTER_GOODS
    {
        // Add custom code here
    }
}

