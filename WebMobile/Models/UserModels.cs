using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMobile.Models.db;
using WebMobile.ViewModel;

namespace WebMobile.Models
{
    public class UserModels
    {
        public User ConvertUserViewToUserEntity(UserViewModel UserVM)
        {
            User UserModel = new User();

            UserModel.FirstName = UserVM.FirstName;
            UserModel.LastName = UserVM.FirstName;
            UserModel.BirthDate = UserVM.BirthDate;
            UserModel.Phone = UserVM.Phone;
            UserModel.Email = UserVM.Email;
            UserModel.UserName = UserVM.UserName;
            UserModel.Password = UserVM.Password;
            UserModel.IsAdmin = UserVM.IsAdmin;
            UserModel.Education = UserVM.Education;
            UserModel.Country = UserVM.Country;


            return UserModel;
        }
        public void InsertUser(User UserModel)
        {
            MobileSystemEntities db = new MobileSystemEntities();
            db.Users.Add(UserModel);
            db.SaveChanges();
        }
        public List<User> SendListCountry()
        {
            var Country = new List<User>();



            return Country;
        }
    }
}