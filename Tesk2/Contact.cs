using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesk2
{
    internal class Contact
    {
        public static List<User> contacts = new List<User>();
        public void AddingContact()
        {
            

            Console.Write("Enter Phone Number: ");
            string phone=Console.ReadLine();

            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();

            contacts.Add(new User(phone, fname, lname));

            Console.WriteLine("\nContact Added Successfully!\n");

            
            
        }

        public void EditContact ()
        {
            Console.Write("Enter the phone number to search for the contact: ");
            string phone = Console.ReadLine();

            User contact = contacts.FirstOrDefault(a => a.PhoneNumber == phone);

            if (contact != null)
            {
                Console.Write("Enter Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.Write("Enter First Name: ");
                contact.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                contact.LastName = Console.ReadLine();

                Console.WriteLine("\nContact edit Successfully!\n");
            }

            else Console.WriteLine("\nContact is not found!\n");


        }

        public void DeleteContact ()
        {
            Console.Write("Enter the Phone Number to search for the contact: ");
            string phone = Console.ReadLine();

            User contact = contacts.FirstOrDefault(a => a.PhoneNumber == phone);

            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("\nContact Delete Successfully!\n");
            }

            else Console.WriteLine("\nContact is not found!\n");
        }

        public void ShowAllContacts ()
        {
            int i = 1;

            if (contacts.Count > 0)
            {
                Console.WriteLine("\n____Contact List____\n");

                foreach (User contact in contacts)
                {
                    Console.Write($".{i++} ");
                    contact.Display();
                }
                Console.WriteLine("___________________________\n");
            }

            else 
            { 
                Console.WriteLine("\nNo contacts available!");
                Console.WriteLine("___________________________\n");
            }

            
        }
    }
}
