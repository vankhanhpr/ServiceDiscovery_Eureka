using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.model.filter
{
    public class StoreFilter
    {
        public DateTime time { get; set; }
        public string processname { get; set; }
        public int monthprcess { get; set; }
        public int yearprcess { get; set; }
        public int groupstore { get; set; }

    }
}
