using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository
    {
        string usersFileParth = @"D:\users.json";

        public UserRepository()
        {
            if (!System.IO.File.Exists(usersFileParth))
            {
                System.IO.File.Create(usersFileParth);
            }
        }
        
        public List<User> getUsers()
        {
            var result = new List<User>();

            try
            {
                var fileStinrg = System.IO.File.ReadAllText(usersFileParth);
                result = JsonConvert.DeserializeObject<List<User>>(fileStinrg);
                if(result is null)
                {
                    result = new List<User>();
                }

            }
            catch (Exception)
            {

            }
            return result;
        }

        public bool saveUser(List<User> users)
        {
            try
            {
                var stringModel = JsonConvert.SerializeObject(users);
                System.IO.File.WriteAllText(usersFileParth, stringModel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
