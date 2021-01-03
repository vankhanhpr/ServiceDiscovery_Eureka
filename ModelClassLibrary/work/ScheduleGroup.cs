using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class ScheduleGroup
    {
        [Key]
        public int schedulegroupid { get; set; }
        public int projectid { get; set; }
        public string name { get; set; }
        public int status { get; set; }
        public Boolean active { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public string userupdate { get; set; }
    }
}
