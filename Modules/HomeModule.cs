using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                var allContacts = Contact.GetAll();
                return View["index.cshtml", allContacts];
            };

            Post["/"] = _ => {
                var newContact = new Contact(Request.Form["contact-name"]);
                var allContacts = Contact.GetAll();
                return View["/", allContacts];
            };

            Get["/new_contact"] = _ => {
                return View["add_contact_form.cshtml"];
            };
        }
    }
}
