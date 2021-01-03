using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.contract
{
    public class C_Contract
    {
        [Key]
        public int hopdong_id { get; set; }
        public string so_hd { get; set; }
        public DateTime ngay_hh { get; set; }
        public string ten_kh { get; set; }
        public string diachi_kh { get; set; }
        public string ten_pm { get; set; }
        public Boolean trangthai { get; set; }
        public DateTime ngayky { get; set; }
        public DateTime thangphatsinh_dt { get; set; }
        public DateTime ngayhl { get; set; }

    }
}
