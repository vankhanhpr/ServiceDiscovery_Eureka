using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.unit
{
    public class Units
    {
        [Key]
        public int unitid { get; set; }
        public string unitname { get; set; }
        public int parentid { get; set; }
        public int unittype { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public Boolean active { get; set; }
        public string userupdate { get; set; }
        public string code { get; set; }
    }
}
