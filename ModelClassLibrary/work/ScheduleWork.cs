using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class ScheduleWork
    {
        [Key]
        public int sheduleid { get; set; }
        public int workdetail_id { get; set; }
        //public int schedulegroupid { get; set; }
        public int staffid { get; set; }
        public int user_performance { get; set; }
        public int timecomplete { get; set; }
        public int jobassignment { get; set; }
        public int righttime { get; set; }
        public int righttimelv2 { get; set; }
        public string urgency { get; set; }
        public string plans { get; set; }
        public string userupdate { get; set; }
        public int status { get; set; }
        public DateTime salarycicle { get; set; }
        public DateTime updateday { get; set; }
        public DateTime starttime { get; set; }
        public DateTime successtime { get; set; }
        public Boolean active { get; set; }
    }
}
