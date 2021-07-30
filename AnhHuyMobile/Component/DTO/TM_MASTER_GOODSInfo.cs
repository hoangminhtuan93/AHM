/*************************************************************
'Author         :tuanhm
'OB Name        :TM_MASTER_GOODSInfo
'Created Date   :2020-08-03 7:57:47 AM
'Description    : Was created by GenCode3TierCSharp (maovu)
'History        : 
*************************************************************/
using System;
using System.Data;
namespace AnhHuyMobile
{
public partial class TM_MASTER_GOODSInfo
{
#region Private Members
private Double? _ID;
private int? _ID_TYPE;
private string _CHR_GOODS_NAME;
private int? _INT_QTY;
private Double? _MN_PRICE_IN;
private Double? _MN_PRICE;
private bool? _BIT_USING;
#endregion
#region Public Properties
public Double? ID
{
get { return _ID; }
 set { _ID = value; }
}
public int? ID_TYPE
{
get { return _ID_TYPE; }
 set { _ID_TYPE = value; }
}
public string CHR_GOODS_NAME
{
get { return _CHR_GOODS_NAME; }
 set { _CHR_GOODS_NAME = value; }
}
public int? INT_QTY
{
get { return _INT_QTY; }
 set { _INT_QTY = value; }
}
public Double? MN_PRICE_IN
{
get { return _MN_PRICE_IN; }
 set { _MN_PRICE_IN = value; }
}
public Double? MN_PRICE
{
get { return _MN_PRICE; }
 set { _MN_PRICE = value; }
}
public bool? BIT_USING
{
get { return _BIT_USING; }
 set { _BIT_USING = value; }
}
#endregion
public TM_MASTER_GOODSInfo()
{
}
public TM_MASTER_GOODSInfo(Double? ID,int? ID_TYPE,string CHR_GOODS_NAME,int? INT_QTY,Double? MN_PRICE_IN,Double? MN_PRICE,bool? BIT_USING)
{
this.ID = ID;
this.ID_TYPE = ID_TYPE;
this.CHR_GOODS_NAME = CHR_GOODS_NAME;
this.INT_QTY = INT_QTY;
this.MN_PRICE_IN = MN_PRICE_IN;
this.MN_PRICE = MN_PRICE;
this.BIT_USING = BIT_USING;
}
}
}
