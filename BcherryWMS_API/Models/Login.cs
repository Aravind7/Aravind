using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    [Table("usm_ms_user_mast")]
    public class Login
    {
        [Key]
        public int usm_user_id { get; set; }
        public string usm_Login_id { get; set; }
        public string usm_display_name { get; set; }
        public string usm_user_pwd { get; set; }
        public Nullable<int> usm_role_id { get; set; }
        public string usm_user_type { get; set; }
        public string usm_lock_status { get; set; }
        public string usm_active { get; set; }
        public Nullable<System.DateTime> usm_acnt_unlck_date { get; set; }
        public string usm_email_id { get; set; }
        public string usm_emp_id { get; set; }
        public Nullable<int> usm_add_user { get; set; }
        public Nullable<System.DateTime> usm_add_date { get; set; }
        public string usm_unit_code { get; set; }
        public string usm_user_categ { get; set; }
        public Nullable<int> usm_serv_type { get; set; }
        public string usm_fm_code { get; set; }
        public Nullable<int> usm_pwd_seq { get; set; }
        public Nullable<System.DateTime> USM_LOCK_FROM_DATE { get; set; }
        public Nullable<System.DateTime> USM_LOCK_TO_DATE { get; set; }
        public string usm_log_type { get; set; }
    }
}