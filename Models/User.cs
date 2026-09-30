using System;
using System.Collections.Generic;
using System.Text;

namespace ef_core.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
