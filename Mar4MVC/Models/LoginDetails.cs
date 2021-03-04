using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mar4MVC.Models
{
    public class LoginDetails
    {
        [Key]
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
        public LoginDetails(String us, String p,String r)
        {
            UserName = us;
            Password = p;
            Role = r;
        }
        public LoginDetails()
        {

        }

        }
    }


