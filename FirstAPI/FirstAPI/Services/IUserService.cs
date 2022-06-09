using FirstAPI.Models;
using System.Threading.Tasks;

namespace FirstAPI.Services
{
    public interface IUserService
    {
        Task<UserDTO> Login(UserDTO user);
        Task<UserDTO> Register(UserDTO user);
        Task<UserDTO> UpdatePassword(UserDTO user);

        Task<UserDTO> UpdateRole(UserDTO user);
    }
}
