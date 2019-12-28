﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cargo.Models
{
    public class mvcCargoModel
    {
        public decimal CREATION { get; set; }
        public Nullable<decimal> BUS_TYPE { get; set; }
        public Nullable<decimal> CLIENT_TYPE { get; set; }
        public Nullable<decimal> CLIENT_STATUS { get; set; }
        public int PARTY_CODE { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string ADDRESS_PERM { get; set; }
        public string ADDRESS_PRES { get; set; }
        public string ADDRESS_CITY { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<decimal> CNIC { get; set; }
        public Nullable<System.DateTime> CNIC_EXPIRY { get; set; }
        public string NTN { get; set; }
        public string INCORP_NO { get; set; }
        public Nullable<System.DateTime> INCORP_DATE { get; set; }
        public string CONTACT_PERSON { get; set; }
        public Nullable<decimal> CONTACT_PERSON_CNIC { get; set; }
        public string CONTACT_PERSON_DESIG { get; set; }
        public string CONTACT_PERSON_CELL { get; set; }
        public string CONTACT_PERSON_EMAIL { get; set; }
        public Nullable<decimal> MARKET_MANAGER { get; set; }
        public Nullable<decimal> NO_OF_STAFF { get; set; }
        public Nullable<decimal> NO_OF_OFF { get; set; }
        public Nullable<decimal> YEARLY_TURNOVER { get; set; }
        public string COMMENT { get; set; }
        public string AUTH_STATUS { get; set; }
        public Nullable<System.DateTime> AUTH_DATE { get; set; }
        public Nullable<decimal> AUTH_BY { get; set; }
        public string AUTH_REMARKS { get; set; }
    }
}