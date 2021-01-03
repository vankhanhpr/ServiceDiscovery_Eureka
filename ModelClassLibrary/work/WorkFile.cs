using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class WorkFile
    {
        [Key]
        public int workfile { get; set; }
        public int workdetail_id { get; set; }
        public string namefie { get; set; }
        public Boolean active { get; set; }
        public int status { get; set; }
        public int performer { get; set; }
    }
}
