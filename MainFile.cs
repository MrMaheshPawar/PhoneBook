using System;

namespace Project_01
{
    public class MainFile
    {

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("Hello Welcome to The MP PhoneBook");
            Console.WriteLine("+-----------------------------------------+");
           
            Console.WriteLine("---*---*---* Select Opration---*---*---*");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact By Number");
            Console.WriteLine("3 View All Contact");
            Console.WriteLine("4 Serach For Contact By Given Name");
            Console.WriteLine("5 Exist \"Better Stay On App\" ");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter Add Contact Name : ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter Add Contact Number :");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        Console.WriteLine("+-----------------------------------------+");

                        break;
                    case "2":
                        Console.WriteLine("Contact Number To Search :");
                        var searchnumber=Console.ReadLine();
                        phoneBook.DisplayContact(searchnumber);
                        Console.WriteLine("+-----------------------------------------+");

                        break;
                    case "3":
                        phoneBook.DisplayAllContact();
                        Console.WriteLine("+-----------------------------------------+");

                        break;
                    case "4":
                        Console.WriteLine("Name Search phras");
                        var searchphras = Console.ReadLine();

                        phoneBook.DisplayMacthingContact(searchphras);
                        Console.WriteLine("+-----------------------------------------+");

                        break;
                    case "5":
                        return;
                        Console.WriteLine("+-----------------------------------------+");

                    default:
                        Console.WriteLine("Select Valid Opration");
                        break;
                        Console.WriteLine("+-----------------------------------------+");
                }
                Console.WriteLine("Select Opration");
                userInput=Console.ReadLine();
            }
           
        }
    }
}
