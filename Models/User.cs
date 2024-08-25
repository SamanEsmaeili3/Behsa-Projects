using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : IEquatable<User>
    {
        public string userName { get; set; }
        public string password { get; set; }
        //public List<Contact> contacts { get; set; }
        public string phoneBookFilePath { get; set; }

        public bool Equals(User other)
        {
            if(this.userName == other.userName)
            {
                return true;
            }
            return false;
        }
    }
}
