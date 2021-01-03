using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.staff
{
    public class Staff
    {
        [Key]
        public int staffid { get; set; }
        public string ma_nv_hrm { get; set; }
        public string ten_nv { get; set; }
        public string ma_dv { get; set; }
        public string ten_dv { get; set; }
        public string ma_pb { get; set; }
        public string ten_pb { get; set; }
        public string ma_bophan { get; set; }
        public string ten_bophan { get; set; }
        public string ma_chucdanh { get; set; }
        public string ten_chucdanh { get; set; }
        public string ma_vtcv { get; set; }
        public string ten_vtcv { get; set; }
        public string ngayhieuluc { get; set; }
        public string hesoluong { get; set; }
        public string hesonscl { get; set; }
        public string khungluong { get; set; }
        public string bacluong { get; set; }
        public string email { get; set; }
        public string ma_nv { get; set; }
        public string ma_khoi { get; set; }
        public int unitid { get; set; }
        public int positionid { get; set; }
        public string ma_to { get; set; }

    }
}
