using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Start
    {
        public void Run()
        {
            var contact = new List<Contact>
            {
                new Contact("Ivan", "Ivanov", "+380123456789"),
                new Contact("Pety", "Petrov", "+380125468546"),
                new Contact("Alexandr", "Alexandrovov", "+380123456978"),
            };

            foreach (var item in contact)
            {
                item.Displey();
            }

            Console.WriteLine("FirstOrDefault");
            var ferstContact = contact.FirstOrDefault(contact => contact.FirstName == "Alexandr");
            ferstContact?.Displey();

            Console.WriteLine("Where,Select");
            var returnList = contact.Where(x => x.FirstName.StartsWith("P")).Select(c => $"{c.FirstName} {c.LastName}").ToList();

            foreach (var item in returnList)
            {
                Console.WriteLine(item);
                Console.WriteLine(new string('-', 70));
            }

            Console.WriteLine("ElementAt");
            var elemenAtContact = contact.ElementAt(2);
            elemenAtContact.Displey();

            Console.WriteLine("OrderBy");
            var orderByContact = contact.OrderBy(x => x.PhoneNamber).ToList();
            foreach (var item in orderByContact)
            {
                item.Displey();
            }

            Console.WriteLine("Any");
            Console.WriteLine(contact.Any(x => x.FirstName == "Ivan"));
        }
    }
}
