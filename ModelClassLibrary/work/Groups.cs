using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class Groups
    {
        [Key]
        public int groupid { get; set; }
        public string groupname { get; set; }
        public int department_id { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public Boolean active { get; set; }
    }
}
