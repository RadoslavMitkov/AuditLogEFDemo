using System.Collections.Generic;
using System.Linq;
using AuditLogAPI.Data;
using AuditLogAPI.Models;
using AuditLogAPI.Services.Interfaces;

namespace AuditLogAPI.Services.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext context;

        public UserService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return this.context.Users;
        }

        public User GetById(int id)
        {
            return this.context.Users.Find(id);
        }

        public void Create(User newUser)
        {
            this.context.Users.Add(newUser);
            this.context.SaveChanges();
        }

        public void Update(User dbUser, User newUser)
        {
            dbUser.Name = newUser.Name;
            dbUser.Age = newUser.Age;

            this.context.Users.Update(dbUser);
            this.context.SaveChanges();
        }

        public void Delete(User dbUser)
        {
            this.context.Users.Remove(dbUser);
            this.context.SaveChanges();
        }
    }
}
