using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RepositoryFactory
    {
        public static UserRepository GetUsersRepository()
        {
            string path = ConfigurationManager.AppSettings["filePath"];
            return new UserRepository(path + "users.txt");
        }

        public static ContactsRepository GetContactsRepository()
        {
            string path = ConfigurationManager.AppSettings["filePath"];
            return new ContactsRepository(path + "contacts.txt");
        }

        public static PhoneRepository GetPhonesRepository()
        {
            string path = ConfigurationManager.AppSettings["filePath"];
            return new PhoneRepository(path + "phones.txt");
        }
    }
}
