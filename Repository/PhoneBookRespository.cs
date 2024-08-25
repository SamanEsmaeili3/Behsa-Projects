using Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PhoneBookRespository
    {

        string filePath = @"D:\data.json";

        //public void SetFilePath(User user)
        //{
        //    try
        //    {
        //        if(user != null) {
        //            filePath = @"D:\" + user.userName + " data.json";
        //            if (!System.IO.File.Exists(filePath))
        //            {
        //                System.IO.File.Create(filePath);
        //            }
        //        }
                
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
        
        public PhoneBookRespository()
        {
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Create(filePath);
            }

        }

        public PhoneBookRespository(User user)
        {
            try
            {
                if (user != null)
                {
                    filePath = @"D:\" + user.userName + " data.json";
                    if (!System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Create(filePath);
                    }
                }

            }
            catch (Exception)
            {

            }
        }
        public List<Contact> GetContacts()
        {
            var result = new List<Contact>();

            try
            {
                var fileString = System.IO.File.ReadAllText(filePath);
                result = JsonConvert.DeserializeObject<List<Contact>>(fileString);
                if (result == null)
                {
                    result = new List<Contact>();
                }
                bool hasInvalidId = false;
                foreach (var contact in result)
                {
                    if (contact.Id == null || contact.Id == Guid.Empty)
                    {
                        hasInvalidId = true;
                        contact.Id = Guid.NewGuid();
                    }
                }
                if (hasInvalidId)
                {
                    SaveContact(result);
                }

            }
            catch (Exception)
            {

            }


            return result;

        }

        public bool SaveContact(List<Contact> model)
        {

            try
            {
                var stringModel = JsonConvert.SerializeObject(model);
                System.IO.File.WriteAllText(filePath, stringModel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }



    }
}
