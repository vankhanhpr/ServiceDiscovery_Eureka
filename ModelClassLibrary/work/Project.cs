using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class Project
    {
        [Key]
        public int projectid { get; set; }
        public string projectname { get; set; }
        public DateTime starttime { get; set; }
        public DateTime endtime { get; set; }
        public string code { get; set; }
        public int status { get; set; }
        public Boolean active { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public string userupdate { get; set; }
        public int typeproject_id { get; set; }

    }
}
