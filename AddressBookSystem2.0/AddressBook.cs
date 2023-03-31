using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem2._0
{
    class AddressBook
    {
        public List<Contact > ContactList;
        public AddressBook()
        {
            this.ContactList = new List<Contact>();
        }
        public void AddContact(Contact contactObj)
        {
            if (this.ContactList.Find(e => e.Equals(contactObj)) != null)
                Console.WriteLine("The Contact Already Exists! Try Again.");
            else
                this.ContactList.Add(contactObj);
        }
        public int FindByPhoneNum(long phoneNumber)
        {
            return this.ContactList.FindIndex(contact => contact.PhoneNumber.Equals(phoneNumber));
        }
        public int FindByFirstName(string firstName)
        {
            return this.ContactList.FindIndex(contact => contact.FirstName.Equals(firstName));
        }
        public void DeleteContact(int index)
        {
            this.ContactList.RemoveAt(index);
        }
    }
}

