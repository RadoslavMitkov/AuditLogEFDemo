using AuditLogAPI.Models;
using AuditLogAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AuditLogAPI.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            var users = this.userService.GetAll().ToArray();

            return users;
        }

        // GET users/5
        [HttpGet("{id:int}")]
        public ActionResult<User> Get(int id)
        {
            var user = this.userService.GetById(id);

            if (user == null)
            {
                return this.NoContent();
            }

            return user;
        }

        // POST users
        [HttpPost]
        public ActionResult<User> Create([FromBody] User newUser)
        {
            this.userService.Create(newUser);

            return CreatedAtAction("Create", newUser);
        }

        // PUT users/5
        [HttpPut("{id:int}")]
        public ActionResult<User> Update(int id, [FromBody] User newUser)
        {
            var dbUser = this.userService.GetById(id);

            if (dbUser == null)
            {
                return this.NoContent();
            }

            this.userService.Update(dbUser, newUser);

            newUser.Id = id;

            return newUser;
        }

        // DELETE users/5
        [HttpDelete("{id:int}")]
        public ActionResult<User> Delete(int id)
        {
            var dbUser = userService.GetById(id);

            if (dbUser == null)
            {
                return this.NoContent();
            }

            this.userService.Delete(dbUser);

            return dbUser;
        }
    }
}
