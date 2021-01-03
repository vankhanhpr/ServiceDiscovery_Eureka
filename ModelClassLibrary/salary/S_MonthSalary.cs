using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ModelClassLibrary.salary
{
    public class S_MonthSalary
    {
        [Key]
        public int id { get; set; }
        public DateTime chuky { get; set; }
        public DateTime ngaytao { get; set; }
        public DateTime ngaycapnhat { get; set; }
        public string nguoitao { get; set; }
        public Boolean trangthai { get; set; }
        public int ngaycongchuan { get; set; }
    }
}
