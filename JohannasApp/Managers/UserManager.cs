using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JohannasApp.Managers
{
    public class UserManager
    {
        public User LoginUserById(string id)
        {
            using (var db = new JohannaContext())
            {
                var users = db.Users.Find(id);
                return users;
            }


        }

        public void RegisterUser(User user)
        {
            using (var db = new JohannaContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}