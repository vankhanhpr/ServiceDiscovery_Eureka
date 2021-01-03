using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClassLibrary.work
{
    public class ScheduleStaff
    {
        public int scheduleid { get; set; }
        public int staffid { get; set; }
        public int status { get; set; }
        public DateTime salarycicle { get; set; }
        public DateTime createtime { get; set; }
        public DateTime updatetime { get; set; }
        public DateTime successtime { get; set; }
        public int timecomplete { get; set; }
        public int righttime { get; set; }
        public int righttimelv2 { get; set; }
        public Boolean active { get; set; }

    }
}
