using System;
using System.Collections.Generic;
using System.Text;

namespace Project_01
{
    class Contact
    {
        public Contact(string name ,String number)
        {
            Name = name;
            Number = number;
        }
    
        public string Name { get; set; }
        public string Number { get; set; }
       
    }
    
}
