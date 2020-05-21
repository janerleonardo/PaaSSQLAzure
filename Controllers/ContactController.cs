using System.Collections.Generic;
using System.Linq;
using WebApiSQLAzure.Models;
using Microsoft.AspNetCore.Mvc;
namespace WebApiSQLAzure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private ContactsContext contactsContext;

        public ContactController(ContactsContext context)
        {
            contactsContext = context;
        }

         [HttpGet]
        public IEnumerable<Contacts> Get()
        {
    
            return contactsContext.ContactSet.ToList();
        }
        [HttpGet ("{id}")]
        public ActionResult<Contacts>  Get (string id) 
        {
            var selected = (from c in contactsContext.ContactSet
                            where c.Id == id
                            select c).FirstOrDefault();
            return selected;
        }


        [HttpPost]
        public ActionResult Save ([FromBody] Contacts model) 
        {
            Contacts item = model;
            contactsContext.ContactSet.Add(item);
            contactsContext.SaveChanges ();
            return Ok ("Agregado correctamente!");
        }

        [HttpPut]
        public ActionResult Update ([FromBody] Contacts model) 
        {
           Contacts updatedContact = model;
            var selectedElement = contactsContext.ContactSet.Find(updatedContact.Id);
            selectedElement.Nombre = model.Nombre;
            selectedElement.Email = model.Email;
            contactsContext.SaveChanges();
             return Ok ("Agregado correctamente!");
        }

        [HttpPost]
        public ActionResult Delete ([FromBody] Contacts model) 
        {
            var selectedElement = contactsContext.ContactSet.Find(model.Id);
            contactsContext.ContactSet.Remove(selectedElement);
            contactsContext.SaveChanges();
            return Ok ("Agregado correctamente!");
        }
        

        ~ContactController () {
            contactsContext.Dispose();
        }   


    }
}