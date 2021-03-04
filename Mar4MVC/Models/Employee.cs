using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mar4MVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String UserName { get; set; }


        [ForeignKey("UserName")]

        public LoginDetails Login { get; set; }

    }
}