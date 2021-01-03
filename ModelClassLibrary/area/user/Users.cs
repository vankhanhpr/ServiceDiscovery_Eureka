using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelClassLibrary.area.user
{
    public class Users
    {
        [Key]
        public int usid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public int role { get; set; }
        public int unitid { get; set; }
        public int positionid { get; set; }
        public int staffid { get; set; }
        public string avatar { get; set; }
    }
    
}
