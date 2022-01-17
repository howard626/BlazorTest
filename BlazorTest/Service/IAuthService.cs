using BlazorTest.Models;
using System.Threading.Tasks;

namespace BlazorTest.Service
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(User userInfo);
        Task LogoutAsync();
    }
}