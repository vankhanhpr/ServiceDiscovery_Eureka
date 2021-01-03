using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ModelClassLibrary.salary
{
    public class S_StaffMonth
    {
        [Key]
        public int id { get; set; }
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
        public decimal? hesoluong { get; set; }
        public decimal? hesonscl { get; set; }
        public string khungluong { get; set; }
        public string bacluong { get; set; }
        public string email { get; set; }
        public string ma_khoi { get; set; }
        public int? unitid { get; set; }
        public string ma_to { get; set; }
        public int? positionid { get; set; }
        public decimal? p1dieuchinh { get; set; }
        public decimal? luongkhoan { get; set; }
        public decimal? nscl_tapthe { get; set; }
        public decimal? ngaycong { get; set; }
        public decimal? ngaycongchuan { get; set; }
        public DateTime ngaytao { get; set; }
        public DateTime ngaycapnhat { get; set; }
        public decimal? heso_bhxh { get; set; }
        public DateTime chuky { get; set; }
    }
}
