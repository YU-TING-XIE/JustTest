using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _123.Models
{
    [Table("News")]

    public class NewsModel
    {
        //設定不可為空值，設定主鍵
        [Required]
        [Key]
        public int N_Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }

    }
}