using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entity.Model
{
   public class RegisterTemp
    {
        public int RegisterTempID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public bool IsStudent { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Role { get; set; }
    }
}
