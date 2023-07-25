using AuthenticationApi.Dtos;

namespace AuthenticationApi.Services;

public interface IAuthentiticationService
{
    Task<string> Register(RegisterRequest request);
    Task<string> Login(LoginRequest request);
}