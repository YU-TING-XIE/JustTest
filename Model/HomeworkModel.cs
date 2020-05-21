using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace _123.Models
{
    [Table("Homework")]
    public class HomeworkModel
    {
        //設定不可為空值 設定主鍵
        [StringLength(10)]
        [Required]

        public string H_Id { get; set; }

        [StringLength(50)]
        [Required]
        public string FileName { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }

        [Required]
        public string M_Id { get; set; }

        [Required]
        public int C_Id { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}