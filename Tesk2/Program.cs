using System.Runtime.CompilerServices;

namespace Tesk2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Contact contact = new Contact();
            bool program = true;

            while (program)
            {

                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Show All Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your Choice: ");
                string cho = Console.ReadLine();

                switch (cho)
                {
                    case "1":
                        contact.AddingContact();
                        break;

                    case "2":
                        contact.EditContact();
                        break;

                    case "3":
                        contact.DeleteContact();
                        break;

                    case "4":
                        contact.ShowAllContacts();
                        break;

                    case "5":
                        program = false;
                        Console.WriteLine("The program has ended!");
                        break;

                    default:
                        Console.WriteLine("Invaild choice! Pleace try again.");
                        break;


                }




            }



        }
    }
}