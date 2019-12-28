using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cargo.Models
{
    public class CAR_DEF_ACC_MGR
    {
        public int CODE { get; set; }
        public string EMP_CODE { get; set; }
        public string NAME { get; set; }
        public string DESIG { get; set; }
        public Nullable<decimal> BRANCH_CODE { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE { get; set; }
        public byte[] SIGN { get; set; }
        public string AUTH_STATUS { get; set; }
        public Nullable<System.DateTime> AUTH_DATE { get; set; }
        public Nullable<decimal> AUTH_BY { get; set; }
        public string AUTH_REMARKS { get; set; }
        public Nullable<decimal> INACTIVE { get; set; }
    }
}