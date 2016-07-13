using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
       [Table("cmd_ms_clnt")]
    public class ClientDetails
    {
        [Key]
        public string cmd_clnt_code { get; set; }
        public string cmd_fst_name { get; set; }
        public string cmd_mid_name { get; set; }
        public string cmd_lst_name { get; set; }
        public string cmd_sht_name { get; set; }
        public Nullable<int> cmd_perm_addr_code { get; set; }
        public Nullable<int> cmd_corr_addr_code { get; set; }
        public string cmd_fmly_code { get; set; }
        public string cmd_is_hof { get; set; }
        public Nullable<System.DateTime> cmd_regn_date { get; set; }
        public string cmd_inv_type { get; set; }
        public string cmd_pan_no { get; set; }
        public string cmd_active { get; set; }
        public Nullable<int> cmd_add_user { get; set; }
        public Nullable<System.DateTime> cmd_add_date { get; set; }
        public Nullable<System.DateTime> cmd_last_updated { get; set; }
        public string cmd_ent_code { get; set; }
        public string cmd_prspct_stat { get; set; }
        public string cmd_label { get; set; }
        public Nullable<int> cmd_lead_acnt_code { get; set; }
        public int cmd_uniq_id { get; set; }
        public string CMD_DFLT_ADDR_INDR { get; set; }
        public string CMD_TYPE { get; set; }
        public string cmd_rm_code { get; set; }
        public string cmd_add_rm_code { get; set; }

    }
}