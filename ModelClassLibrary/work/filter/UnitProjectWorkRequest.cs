using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClassLibrary.work.filter
{
    public class UnitProjectWorkRequest
    {
        public int projectid { get; set; }
        public List<int> listunit { get; set; }
        public List<int> listwork { get; set; }
        public string userupdate { get; set; }
        public DateTime fromday { get; set; }
        public DateTime today { get; set; }
    }
}
