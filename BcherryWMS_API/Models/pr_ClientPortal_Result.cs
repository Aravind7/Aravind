using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class pr_ClientPortal_Result
    {
        [Key]
        public string asset_class_type { get; set; }
        public Nullable<int> gld_bus_ln_no { get; set; }
        public System.Decimal gld_cost_value { get; set; }
        public System.Decimal gld_mkt_value { get; set; }
        public System.Decimal gld_day_gain_loss { get; set; }
        public System.Decimal gld_real_gl_amt { get; set; }
        public System.Decimal gld_unreal_gl_amt { get; set; }
        public System.Decimal gld_real_gl_pct { get; set; }


    }
}