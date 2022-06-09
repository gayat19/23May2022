using FirstAPI.Models;

namespace FirstAPI.Services
{
    public interface ITokenService
    {
        public string CreateToken(UserDTO user);
    }
}
