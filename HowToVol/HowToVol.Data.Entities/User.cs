using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToVol.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        // Other user-related properties

        // Navigation properties
        public ICollection<Interest> Interests { get; set; }
        public ICollection<UserInterest> UserInterests { get; set; }
    }

}
