using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToVol.Data.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Other organization-related properties

        // Navigation properties
        public ICollection<Event> Events { get; set; }
    }

}
