using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class AccountData
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int IDCart { set; get; }
        public string HomeTown { set; get; }
        public string Nation { set; get; }
        public string Religion { set; get; }
        public DateTime DateOfBirth { get; set; }
        public string FullName { set; get; }
    }
}