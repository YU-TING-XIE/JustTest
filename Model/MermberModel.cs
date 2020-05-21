using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _123.Model
{
    [Tabel("Member")]
    public class Members
    {
        //會員ID
        [Required]
        public string M_Id { get; set; }

        //帳號
        [StringLength(30, MinimumLength = 6)]
        [Required]
        public string Account { get; set; }

        //密碼
        [Required]
        public string Password { get; set; }

        //姓名
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        //性別
        [Required]
        public bool Gender { get; set; }

        //族別
        [Required]
        [StringLength(20)]
        public string Tribes { get; set; }

        //服務單位
        [Required]
        [StringLength(20)]
        public string JobTitle { get; set; }

        //聯絡地址
        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        //電話
        [Required]
        [StringLength(10)]
        public string Phone { get; set; }

        //電子信箱
        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        //驗證碼
        [Required]
        public string AuthCode { get; set; }

        //是否驗證
        [Required]
        public bool Check { get; set; }

        //管理員
        [Required]
        public bool IsAdmin { get; set; }
    }


}