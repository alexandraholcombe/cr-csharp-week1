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

            Post["/contact/success"] = _ => {
                var newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone-number"], Request.Form["contact-address"]);
                newContact.SaveContact();
                return View["contact_added.cshtml", newContact];
            };

            Get["/contact/new"] = _ => {
                return View["add_contact_form.cshtml"];
            };

            Get["/contact/{id}"] = parameters => {
                Contact contact = Contact.Find(parameters.id);
                return View["view_contact.cshtml", contact];
            };

            Post["/contact/clear"] = _ => {
                Contact.ClearAll();
                return View["contact_clear.cshtml"];
            };

            Post["/contact/{id}/remove"] = parameters => {
                Contact contact = Contact.Find(parameters.id);
                contact.RemoveContact();
                return View["remove_contact.cshtml"];
            };

            Get["/search"] = _ => {
                return View["search_form.cshtml"];
            };

            Post["/search_results"] = _ => {
                Contact selectedContact = Contact.SearchContact(Request.Form["search"]);
                return View["view_contact.cshtml", selectedContact];
            };
        }
    }
}
