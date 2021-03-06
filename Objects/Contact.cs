using System.Collections.Generic;
using Nancy;

namespace AddressBook.Objects
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _address;
        private int _id;
        private static List<Contact> _instances = new List<Contact>{};

        public Contact(string name, string phoneNumber, string address)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
            // _instances.Add(this);
            _id = _instances.Count + 1;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string inputName)
        {
            _name = inputName;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public void SetPhoneNumber(string inputPhoneNumber)
        {
            _phoneNumber = inputPhoneNumber;
        }

        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string inputAddress)
        {
            _address = inputAddress;
        }

        public static List<Contact> GetAll()
        {
            return _instances;
        }

        public void SaveContact()
        {
            _instances.Add(this);
        }

        public int GetId()
        {
            return _id;
        }

        public static Contact Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public void RemoveContact()
        {
            _instances.Remove(this);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Contact SearchContact(string searchTerm)
        {
            foreach (var contact in _instances)
            {
                if (contact.GetName() == searchTerm)
                {
                    return contact;
                }
            }
            return null;
        }
    }
}
