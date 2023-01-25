using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_01
{
    class PhoneBook
    {
        // private List

        private List<Contact> _contact{get; set;}=new List<Contact>();

        // Private method For Use All Duplicate codes
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact :{contact.Name},Number :{contact.Number}");
        }
        private void DisplayContactsDetails(List<Contact>contact)
        {
            foreach (var contacts in contact)
            {
                DisplayContactDetails(contacts);
            }
        }

        // Add Contact Method

        public void AddContact(Contact contact)
        {
            _contact.Add(contact);
        }
        
        // DisplayContact Method
        
        public void DisplayContact(string number)
        {
            var contact = _contact.FirstOrDefault(C=>C.Number==number);
            if(contact == null)
            {
                Console.WriteLine("Contact Does Not Found");
            }
            else
            {
                Console.WriteLine($"Contact :{contact.Name},Number :{contact.Number}");
            }
        }

        // Display All Contact Method

        public void DisplayAllContact()
        {
            DisplayContactsDetails(_contact);
        }
        
        
        // Display Search Matches
        public void DisplayMacthingContact(string serachphrse)
        {
            var matchingContact = _contact.Where(c => c.Name.Contains(serachphrse)).ToList();
            DisplayContactsDetails(matchingContact);
        }


    }
}
