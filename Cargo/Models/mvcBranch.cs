using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cargo.Models
{
    public class mvcBranch
    {
        public decimal CODE { get; set; }
        public string DESC { get; set; }
        public string ABRV { get; set; }
        public Nullable<decimal> CITY_CODE { get; set; }
        public Nullable<decimal> HDBR_CD { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string MANAGER { get; set; }
        public string AUTH_STATUS { get; set; }
        public Nullable<System.DateTime> AUTH_DATE { get; set; }
        public Nullable<decimal> AUTH_BY { get; set; }
        public string AUTH_REMARKS { get; set; }
        public Nullable<decimal> INACTIVE { get; set; }
    }
}