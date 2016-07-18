namespace DataAccess.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataAccess.Repository;
    using DataAccess.Entity;

    public class Auth
    {
        public static UserEntity LoggedUser { get; private set; }

        public static void AuthenticateUser(string username, string password)
        {
            UserRepository userRepository = RepositoryFactory.GetUsersRepository();
            LoggedUser = userRepository.GetByUsernameAndPassword(username, password);
        }
    }
}
