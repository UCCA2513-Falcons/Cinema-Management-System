using Falcons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Functions
{
    public class User_CRUD
    {
        private readonly FalconsDBContext _context;

        public User_CRUD(FalconsDBContext context)
        {
            _context = context;
        }

        public List<Role> GetAllRoles()
        {
            return _context.Role.ToList();
        }

        public Role GetRole(int? id)
        {
            if(id != null)
            {
                return _context.Role.Find(id);
            }else
            {
                return null;
            }
        }

        public void CreateRole(string title, string position)
        {
            Role ur = new Role()
            {
                RoleTitle = title,
                Position = position
            };
            _context.Role.Add(ur);
            _context.SaveChanges();
        }

        public void UpdateRole(int id, string title, string position)
        {
            Role ur = _context.Role.Find(id);
            ur.RoleTitle = title;
            ur.Position = position;

            _context.Role.Update(ur);
            _context.SaveChanges();
        }

        public void DeleteRole(int id)
        {
            _context.Role.Remove(_context.Role.Find(id));
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        public User GetUser(int id)
        {
            return _context.User.Find(id);
        }

        public void CreateUser(string first, string last, string password, string email, DateTime dob, string phone, int roleId)
        {
            User user = new User()
            {
                FirstName = first,
                LastName = last,
                Email = email,
                Password = password,
                DateOfBirth = dob,
                PhoneNo = phone,
                Role = _context.Role.Find(roleId)
            };
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(int userId, string first, string last, string password, string email, DateTime dob, string phone, int roleId)
        {
            User user = _context.User.Find(userId);
            user.FirstName = first;
            user.LastName = last;
            user.Password = password;
            user.Email = email;
            user.DateOfBirth = dob;
            user.PhoneNo = phone;
            user.Role = _context.Role.Find(roleId);

            _context.User.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userId) {
            _context.User.Remove(_context.User.Find(userId));
            _context.SaveChanges();
        }
    }
}
