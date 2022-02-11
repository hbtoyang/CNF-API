using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNFEFCore;

namespace CNFWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly CNFDbContext dbContext;
        public ContactController(CNFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("id")]
        public ActionResult<Contact> Contact(int id)
        {
            if (id <= 0)
                return BadRequest("Contact id should be larger than 0");
            else
            {
                Contact contact = this.dbContext.Contacts.FirstOrDefault(x => x.Id == id);
                if (contact != null)
                    return contact;
                else
                    return NotFound("Contact not exist");
            }
        }

        [HttpPost]
        public ActionResult<Contact> Contact(Contact contact)
        {
            if (contact != null)
            {
                contact.CreatedDate = DateTime.Now;
                contact.CreatedBy = null;
                contact.UpdateDate = null;
                contact.UpdateBy = null;
                this.dbContext.Contacts.Add(contact);
                this.dbContext.SaveChanges();
                return Ok();
            }
            else
                return BadRequest("Contact not provide");
        }
    }
}
