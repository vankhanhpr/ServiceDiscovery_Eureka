using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.work
{
    public class Department
    {
        [Key]
        public int department_id { get; set; }
        public string department_name { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public Boolean active { get; set; }
    }
}
