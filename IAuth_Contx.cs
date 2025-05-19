using AuthService.DTOs;

namespace AuthService.Services
{
    public interface IAuthService
    {
        Task<string> Register(UserRegisterDto dto);
        Task<string> Login(UserLoginDto dto);
    }
}
