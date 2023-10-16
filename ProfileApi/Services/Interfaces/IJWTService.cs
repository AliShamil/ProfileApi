using System.Security.Claims;

namespace ProfileApi.Services.Interfaces
{
    public interface IJWTService
    {
        string GenerateSecurityToken(string id, string email);
    }
}
