using CNFEFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNFWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly CNFDbContext dbContext;
        public DonationController(CNFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<AmountType>> AmountType()
        {
            return this.dbContext.AmountTypes.ToList();
        }
        [HttpGet]
        public ActionResult<IEnumerable<RecurringType>> RecurringType()
        {
            return this.dbContext.RecurringTypes.ToList();
        }

        [HttpPost]
        public ActionResult<Donation> Donation(DonationVM donation)
        {
            if (donation != null)
            {
                Application newApplication = new Application()
                {

                    City = donation.City,
                    Country = donation.Country,
                    Email = donation.Email,
                    FirstName = donation.FirstName,
                    LastName = donation.LastName,
                    Phone = donation.Phone,
                    Province = donation.Province,
                    PostalCode = donation.PostalCode,
                    Title = donation.Title,
                    IsCorporateDonation = donation.IsCorporateDonation,
                    Organization = donation.Organization,
                    MailingAddress = donation.MailingAddress

                };
                newApplication.CreatedDate = DateTime.Now;
                this.dbContext.Applications.Add(newApplication);
                this.dbContext.SaveChanges();
                return Ok();
            }
            else
                return BadRequest("Donation not provide");

        }
    }

}
