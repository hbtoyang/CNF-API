using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class RecurringType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }

        public ICollection<Donation> Donations { get; set; }
    }
}
