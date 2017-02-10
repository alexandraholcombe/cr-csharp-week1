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

            Post["/contact/new"] = _ => {
                var newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone-number"], Request.Form["contact-address"]);
                newContact.SaveContact();
                return View["contact_added.cshtml", newContact];
            };

            Get["/new_contact"] = _ => {
                return View["add_contact_form.cshtml"];
            };
        }
    }
}
