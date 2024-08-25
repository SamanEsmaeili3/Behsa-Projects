using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService
    {
        UserRepository _repo;

        public UserService()
        {
            _repo = new UserRepository();
        }

        public bool DeleteUser(string userName)
        {
            try
            {
                var users = _repo.getUsers();
                var userForDelete = users.FirstOrDefault(x => x.Equals(userName));
                _repo.saveUser(users);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public User GetUserByUserName(string userName)
        {
            //TO DO: exception handeling
        
            var users = GetUsers();
            var user = users.FirstOrDefault(x => x.userName == userName);
            return user;
        }

        public List<User> GetUsers()
        {
            return _repo.getUsers();
        }

        public bool SaveUser(User user)
        {
            var users = GetUsers();
            if(user != null && !IsDuplicateUser(user))
            {
                users.Add(user);
                return _repo.saveUser(users);
            }
            return false;
        }

        public bool IsDuplicateUser(User user)
        {
            var users = GetUsers();
            foreach(var usr in users)
            {
                if (user.Equals(usr)) { return true; }
            }
            return false;
        }
    }
}
