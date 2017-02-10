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
            _instances.Add(this);
            _id = _instances.Count;
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

        public int GetId()
        {
            return _id;
        }
    }
}
