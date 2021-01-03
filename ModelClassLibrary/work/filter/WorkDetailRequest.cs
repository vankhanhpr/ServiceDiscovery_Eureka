using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClassLibrary.work.filter
{
    public class WorkDetailRequest
    {
        public string name { get; set; }
        public int workid { get; set; }
        public int workdetail_id { get; set; }
        public int projectid { get; set; }
        public Double ratedtime { get; set; }
        public Double ratedtimelv2 { get; set; }
        public int righttime { get; set; }
        public int status { get; set; }
        public int timecomplete { get; set; }
        public Boolean active { get; set; }
        public string code { get; set; }
        public string userupdate { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public IFormFile file { get; set; }
        public string filename { get; set; }
        public int schedulegroupid { get; set; }
    }
}
