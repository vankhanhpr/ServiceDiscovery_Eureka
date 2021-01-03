using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class WorkDetail
    {
        [Key]
        public int workdetail_id { get; set; }
        public string name { get; set; }
        public int workid { get; set; }
        public int projectid { get; set; }
        public Double ratedtime { get; set; }
        public Double ratedtimelv2 { get; set; }
        public int righttime { get; set; }
        public int status { get; set; }
        public Boolean active { get; set; }
        public string code { get; set; }
        public string userupdate { get; set; }
        public string note { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public DateTime starttime { get; set; }
        public DateTime endtime { get; set; }
 
 
    }
}
