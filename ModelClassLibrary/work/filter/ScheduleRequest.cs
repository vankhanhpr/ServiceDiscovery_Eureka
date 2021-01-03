using ModelClassLibrary.area.user;
using ModelClassLibrary.staff;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClassLibrary.work.filter
{
    public class ScheduleRequest
    {
        public List<Staff>  listUser { get; set; }
        public List<WorkDetail>  listWork { get; set; }
        public int schedulegroupid { get; set; }
        public string usud { get; set; }
        public int staffid { get; set; }
        public int workdetail_id { get; set; }
        public int scheduleid { get; set; }
        public int righttime { get; set; }
        public int righttimelv2 { get; set; }
        public string salarycicle { get; set; }
    }
}
