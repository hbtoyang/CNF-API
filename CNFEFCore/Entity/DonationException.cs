using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class DonationException
    {
        public int Id { get; set; }
        public int DonationId { get; set; }
        public bool? IsRescheduled { get; set; }
        public bool? IsCancelled { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public Donation Donation { get; set; }
    }
}
