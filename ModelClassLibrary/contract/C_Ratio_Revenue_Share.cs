using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.contract
{
    public class C_Ratio_Revenue_Share
    {
        [Key]
        public int tldtpc_id { get; set; }
        public int hopdong_id { get; set; }
        public string ma_to { get; set; }
        public Double tyle_huong { get; set; }
        public DateTime ngay_hl { get; set; }
        public DateTime ngayhet_hl { get; set; }
        public string nguoi_cn { get; set; }
        public DateTime ngay_cn { get; set; }

    }
}
