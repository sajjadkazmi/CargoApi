//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CargoAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAR_INQ
    {
        public decimal TRAN_CODE { get; set; }
        public Nullable<System.DateTime> TRAN_DATE { get; set; }
        public Nullable<System.DateTime> VALID_DATE { get; set; }
        public Nullable<decimal> BUS_TYPE { get; set; }
        public Nullable<decimal> CLIENT_STATUS { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<decimal> CNIC { get; set; }
        public string NTN { get; set; }
        public string INCORP_NO { get; set; }
        public Nullable<System.DateTime> INCORP_DATE { get; set; }
        public string CONTACT_PERSON { get; set; }
        public Nullable<decimal> CONTACT_PERSON_CNIC { get; set; }
        public string CONTACT_PERSON_DESIG { get; set; }
        public string CONTACT_PERSON_CELL { get; set; }
        public string CONTACT_PERSON_EMAIL { get; set; }
        public Nullable<decimal> MARKET_MANAGER { get; set; }
        public string DESTINATION { get; set; }
        public string PACK_TYPE { get; set; }
        public string MASS { get; set; }
        public Nullable<System.DateTime> CUST_CLR_DATE { get; set; }
        public string PORT_NAME { get; set; }
        public string COMMENT { get; set; }
        public string AUTH_STATUS { get; set; }
        public Nullable<System.DateTime> AUTH_DATE { get; set; }
        public Nullable<decimal> AUTH_BY { get; set; }
        public string AUTH_REMARKS { get; set; }
    }
}