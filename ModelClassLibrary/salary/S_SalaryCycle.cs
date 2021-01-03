using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.salary
{
    public class S_SalaryCycle
    {
        [Key]
        public int salarycicleid { get; set; }
        public DateTime salarycicle { get; set; }
        public int status { get; set; }
        public Boolean active { get; set; }
    }
}
