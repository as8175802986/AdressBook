using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Contacts
    {
        List<Contacts> addressList = new List<Contacts>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public void AddContact()
        {
            Contacts contact = new Contacts();
            Console.Write("Enter First Name : ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter Address : ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter City : ");
            contact.City = Console.ReadLine();
            Console.Write("Enter State : ");
            contact.State = Console.ReadLine();
            Console.Write("Enter the Zip code : ");
            contact.Zip = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Email ID : ");
            contact.Email = Console.ReadLine();
            addressList.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
            }
        }
    }
}
