using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class WorkGroup
    {
        [Key]
        public int workgroupid { get; set; }
        public string name { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public Boolean active { get; set; }
        public DateTime executionday { get; set; }
        public DateTime endday { get; set; }
        public int unitid { get; set; }
        public string work_property { get; set; }
        public int ratedtime { get; set; }
        public string code { get; set; }


    }
}
