using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClassLibrary.filter
{
    public class UserFilter
    {
        public int  usid { get; set; }
        public IFormFile file { get; set; }
    }
}
