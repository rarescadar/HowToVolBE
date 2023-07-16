using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToVol.Data.Entities
{
    public class Interest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other interest-related properties

        // Navigation properties
        public ICollection<User> Users { get; set; }
        public ICollection<UserInterest> UserInterests { get; set; }
    }

}
