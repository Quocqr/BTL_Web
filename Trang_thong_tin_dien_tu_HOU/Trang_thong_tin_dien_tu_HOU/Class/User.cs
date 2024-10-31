using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trang_thong_tin_dien_tu_HOU
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public object Repeater1 { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Repeater1 = Repeater1;
        }
    }
}