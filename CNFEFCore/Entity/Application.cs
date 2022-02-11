using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class Application
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public bool? IsCorporateDonation { get; set; }
        public string MailingAddress { get; set; }
        public string Province { get; set; }
        public string  City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string  Phone { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public Donation Donation { get; set; }
    }
}
