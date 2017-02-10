using System.Collections.Generic;
using Nancy;

namespace Contact.Objects
{
  public class contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;

    public Contact(string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
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


  }
}
