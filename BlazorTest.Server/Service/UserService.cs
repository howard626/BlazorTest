using BlazorTest.Models;
using BlazorTest.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Server.Service
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            this._context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        public User UserLogin(string account, string password)
        {
            return _context.User.FirstOrDefault(u => u.Account == account && u.Password == password);
        }
    }
}
