/*************************************************************
'Author         :Huy
'OB Name        :TM_SALEInfo
'Created Date   :8/23/2020 9:11:57 AM
'Description    : Was created by GenCode3TierCSharp (maovu)
'History        : 
*************************************************************/
using System;
using System.Data;
namespace AnhHuyMobile
{
public partial class TM_SALEInfo
{
#region Private Members
private Double? _ID;
private DateTime? _DAT_DATE;
private int? _ID_TYPE;
private string _CHR_NAME;
private int? _ID_GOODS;
private int? _INT_GOOD_QTY;
private Double? _CHR_MONEY;
private int? _INT_GUARANTEE_MONTH;
private Double? _CHR_MONEY_IN;
private string _CHR_CUSTOMER;
private string _CHR_CUS_PHONE;
private string _CHR_USER_UPDATE;
private DateTime? _DTM_UPDATE;
#endregion
#region Public Properties
public Double? ID
{
get { return _ID; }
 set { _ID = value; }
}
public DateTime? DAT_DATE
{
get { return _DAT_DATE; }
 set { _DAT_DATE = value; }
}
public int? ID_TYPE
{
get { return _ID_TYPE; }
 set { _ID_TYPE = value; }
}
public string CHR_NAME
{
get { return _CHR_NAME; }
 set { _CHR_NAME = value; }
}
public int? ID_GOODS
{
get { return _ID_GOODS; }
 set { _ID_GOODS = value; }
}
public int? INT_GOOD_QTY
{
get { return _INT_GOOD_QTY; }
 set { _INT_GOOD_QTY = value; }
}
public Double? CHR_MONEY
{
get { return _CHR_MONEY; }
 set { _CHR_MONEY = value; }
}
public int? INT_GUARANTEE_MONTH
{
get { return _INT_GUARANTEE_MONTH; }
 set { _INT_GUARANTEE_MONTH = value; }
}
public Double? CHR_MONEY_IN
{
get { return _CHR_MONEY_IN; }
 set { _CHR_MONEY_IN = value; }
}
public string CHR_CUSTOMER
{
get { return _CHR_CUSTOMER; }
 set { _CHR_CUSTOMER = value; }
}
public string CHR_CUS_PHONE
{
get { return _CHR_CUS_PHONE; }
 set { _CHR_CUS_PHONE = value; }
}
public string CHR_USER_UPDATE
{
get { return _CHR_USER_UPDATE; }
 set { _CHR_USER_UPDATE = value; }
}
public DateTime? DTM_UPDATE
{
get { return _DTM_UPDATE; }
 set { _DTM_UPDATE = value; }
}
#endregion
public TM_SALEInfo()
{
}
public TM_SALEInfo(Double? ID,DateTime? DAT_DATE,int? ID_TYPE,string CHR_NAME,int? ID_GOODS,int? INT_GOOD_QTY,Double? CHR_MONEY,int? INT_GUARANTEE_MONTH,Double? CHR_MONEY_IN,string CHR_CUSTOMER,string CHR_CUS_PHONE,string CHR_USER_UPDATE,DateTime? DTM_UPDATE)
{
this.ID = ID;
this.DAT_DATE = DAT_DATE;
this.ID_TYPE = ID_TYPE;
this.CHR_NAME = CHR_NAME;
this.ID_GOODS = ID_GOODS;
this.INT_GOOD_QTY = INT_GOOD_QTY;
this.CHR_MONEY = CHR_MONEY;
this.INT_GUARANTEE_MONTH = INT_GUARANTEE_MONTH;
this.CHR_MONEY_IN = CHR_MONEY_IN;
this.CHR_CUSTOMER = CHR_CUSTOMER;
this.CHR_CUS_PHONE = CHR_CUS_PHONE;
this.CHR_USER_UPDATE = CHR_USER_UPDATE;
this.DTM_UPDATE = DTM_UPDATE;
}
}
}
