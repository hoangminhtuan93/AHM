/*************************************************************
'Author         :tuanhm
'Business Layer Name        : TM_MASTER_TYPEPartialClass
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
    public partial class TM_MASTER_TYPEInfo
    {
        // Add custom code here
    }
    public partial class BUS_TM_MASTER_TYPE
    {
        // Add custom code here  
        public DataTable TM_MASTER_TYPE_Select_dgv()
        {
            return dbConnection.ExecuteDataset("TM_MASTER_TYPE_Select_dgv", dbAssistant.SetvalueParameter()).Tables[0];
        }
    }
    public partial class DAL_TM_MASTER_TYPE
    {
        // Add custom code here
    }
}

