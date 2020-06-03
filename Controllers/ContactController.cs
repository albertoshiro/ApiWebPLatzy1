using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSQL.Models;

namespace WebApiSQL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {

        private ContactsContext contactsContext;
        public ContactController (ContactsContext context)
        {
            contactsContext = context;
        }
        [HttpGet]
        public ActionResult<List<Contacts>> Get()
        {
            return contactsContext.ContactSet.ToList();
        }
        ~ContactController()
        {
            contactsContext.Dispose();
        }

        
    }
}
