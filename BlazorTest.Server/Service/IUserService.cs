using BlazorTest.Models;
using System.Collections.Generic;

namespace BlazorTest.Server.Service
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User UserLogin(string account, string password);

        string Register(RegisterModel model);
    }
}