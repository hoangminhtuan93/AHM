/*************************************************************
'Author         :tuanhm
'OB Name        :TM_MASTER_TYPEInfo
'Created Date   :2020-08-01 3:37:28 PM
'Description    : Was created by GenCode3TierCSharp (maovu)
'History        : 
*************************************************************/
using System;
using System.Data;
namespace AnhHuyMobile
{
public partial class TM_MASTER_TYPEInfo
{
#region Private Members
private int? _ID;
private string _CHR_TYPE;
private bool? _BIT_USING;
#endregion
#region Public Properties
public int? ID
{
get { return _ID; }
 set { _ID = value; }
}
public string CHR_TYPE
{
get { return _CHR_TYPE; }
 set { _CHR_TYPE = value; }
}
public bool? BIT_USING
{
get { return _BIT_USING; }
 set { _BIT_USING = value; }
}
#endregion
public TM_MASTER_TYPEInfo()
{
}
public TM_MASTER_TYPEInfo(int? ID,string CHR_TYPE,bool? BIT_USING)
{
this.ID = ID;
this.CHR_TYPE = CHR_TYPE;
this.BIT_USING = BIT_USING;
}
}
}
