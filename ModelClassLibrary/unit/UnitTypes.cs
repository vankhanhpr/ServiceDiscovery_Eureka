using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.unit
{
    public class UnitTypes
    {
        [Key]
        public int unittypeid { get; set; }
        public string typename { get; set; }
        public Boolean active { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        
    }
}
