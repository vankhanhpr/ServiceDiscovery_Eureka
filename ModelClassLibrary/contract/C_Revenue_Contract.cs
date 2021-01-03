using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.contract
{
    public class C_Revenue_Contract
    {
        [Key]
        public int dthd_id { get; set; }
        public int hopdong_id { get; set; }
        public Double doanhthu_thang { get; set; }
        public DateTime ngay_hl { get; set; }
        public DateTime ngayhet_hl { get; set; }
        public string nguoi_cn { get; set; }
        public DateTime ngay_cn { get; set; }
    }
}
