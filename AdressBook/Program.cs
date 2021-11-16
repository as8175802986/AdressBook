using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2.Add new \n 3. Edit contacts \n 4. Exit ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details in specified format");
                        Contacts contact = new Contacts()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the contact to be added : ");
                        Contacts con = new Contacts();
                        con.AddContact();
                        con.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the contact you want to Edit");
                        string name = Console.ReadLine();
                        Contacts edit = new Contacts();
                        edit.AddContact();
                        edit.EditContact(name);
                        edit.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
