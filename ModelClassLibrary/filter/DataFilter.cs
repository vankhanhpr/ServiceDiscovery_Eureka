using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.model.filter
{
    public class DataFilter
    {
        public string filter { get; set; }
        public string oldpass { get; set; }
        public string newpass { get; set; }
        public string confirmpass { get; set; }
        public int usid { get; set; }
        public int typeofWork { get; set; }
    }
}
