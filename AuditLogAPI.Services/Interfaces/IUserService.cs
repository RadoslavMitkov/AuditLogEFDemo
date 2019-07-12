using AuditLogAPI.Models;
using System.Collections.Generic;

namespace AuditLogAPI.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        void Create(User user);

        void Update(User dbUser, User user);

        void Delete(User dbUser);
    }
}
