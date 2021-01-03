using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class Works
    {
        [Key]
        public int workid { get; set; }
        public int workgroupid { get; set; }
        public string workname { get; set; }
        public Double realtime { get; set; }
        public Double ratedtime { get; set; }
        public int status { get; set; }
        public string code { get; set; }
        public Boolean active { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public DateTime executionday { get; set; }
        public DateTime endday { get; set; }
        
    }
}
