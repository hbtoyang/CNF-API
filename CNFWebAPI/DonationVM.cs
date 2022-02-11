using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNFWebAPI
{
    public class DonationVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public bool IsCorporateDonation { get; set; }
        public string MailingAddress { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal GiftAmount { get; set; }
        public int AmountTypeId { get; set; }
        public bool IsRecurring { get; set; }
        public int RecurringTypeId { get; set; }
        public int CardType { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime Expiry { get; set; }
        public string CVV { get; set; }
        public string CardHolderName { get; set; }       
    }
}
