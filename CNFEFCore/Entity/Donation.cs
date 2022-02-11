using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class Donation
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public decimal? GiftAmount { get; set; }
        public int? AmountTypeId { get; set; }
        public bool? IsRecurring { get; set; }
        public int? RecurringTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public ICollection<DonationException> DonationExceptions { get; set; }
        public ICollection<DonationHistoryRecord> DonationHistoryRecords { get; set; }
        public AmountType AmountType { get; set; }
        public RecurringType RecurringType { get; set; }
        public Application Application { get; set; }

    }
}
