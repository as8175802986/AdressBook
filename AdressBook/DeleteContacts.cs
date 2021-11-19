using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressBook
{
    class DeleteContacts
    {
        List<Contacts> addressList = new List<Contacts>();
        Dictionary<string, List<Contacts>> dict = new Dictionary<string, List<Contacts>>();
        public void DeleteContact(string user) // This Method Will Delete Particular Contact Detail Provided by User
        {
            Contacts delete = new Contacts();
            foreach (var contact in AddressList) 
            {
                if (contact.FirstName == user || contact.LastName == user)
                {
                    object p = AddressList.Remove(contact);
                }
            }
        }
    }
}
