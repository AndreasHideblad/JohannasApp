using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace JohannasApp.Managers
{
    public class UserManager
    {
        private static UserManager _instance;
        public static UserManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserManager();
                return _instance;
            }
        }
        private UserManager() { }

        public bool CreateUser(User user)
        {
            using (var db = new JohannaContext())
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    return false;
                }
            }
        }

        public User GetUserByUsername(string username)
        {
            using (var db = new JohannaContext())
            {
                var user = db.Users.Find(username);
                return user;
            }
        }
    }
}