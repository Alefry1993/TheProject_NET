using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheProject.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
