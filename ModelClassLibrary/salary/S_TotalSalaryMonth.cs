using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.salary
{
    public class S_TotalSalaryMonth
    {
        [Key]
        public int id { get; set; }
        public DateTime chuky { get; set; }
        public Double tongquyluong { get; set; }
        public Boolean active { get; set; }
        public int status { get; set; }
        public string nguoicn { get; set; }
        public DateTime ngaycn { get; set; }
    }
}
