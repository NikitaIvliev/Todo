using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Desktop.Repository
{
    public class UserRepository
    {
        private static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel{UserName="Admin", EmailAdress="Admin@mail.ru", Password="Admin"},  
        };

        public static bool Authorization(string EmailAdress, string Password)
        {
            foreach (var user in Users)
            {
                if (user.EmailAdress == EmailAdress && user.Password == Password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckUserName(string UserName)
        {
            foreach(var user in Users)
            {
                if (user.UserName == UserName) 
                { 
                return true;
                }
            }
            return false;
        }   
        public static bool CheckUserEmail(string EmailAdress)
        {
            foreach(var user in Users)
            {
                if (user.EmailAdress == EmailAdress) 
                { 
                return true;
                }
            }
            return false;
        }  
        public static void Registration (string UserName, string EmailAdress, string Password)
        {
            Users.Add(new UserModel { UserName=UserName, EmailAdress=EmailAdress, Password=Password});  
        }
    }
}
