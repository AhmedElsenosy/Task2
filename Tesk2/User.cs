using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tesk2
{
    internal class User
    {
        
        

        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public User(string phone , string fn , string ln)
        {
            PhoneNumber = phone;
            FirstName = fn;
            LastName = ln;
        }

        public void Display()
        {
            Console.WriteLine($"Contact: {FirstName+" "+LastName}\nPhone Number: {PhoneNumber}\n");
        }




    }
}
