using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Contact
    {
        public Contact(string firstName, string lasteName, string phoneNamber)
        {
            FirstName = firstName;
            LastName = lasteName;
            PhoneNamber = phoneNamber;
        }

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string PhoneNamber { get; init; }

        public void Displey()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nPH: {PhoneNamber}");
            Console.WriteLine(new string('-', 70));
        }
    }
}
