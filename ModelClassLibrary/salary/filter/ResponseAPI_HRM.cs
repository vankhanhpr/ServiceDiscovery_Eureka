using System;
using System.Collections.Generic;

namespace ModelClassLibrary.salary
{
    public class ResponseAPI_HRM
    {
        public int result { get; set; }
        public string messageReturn { get; set; }
        public List<EmployeesHRM> list { get; set; }
    }
}




