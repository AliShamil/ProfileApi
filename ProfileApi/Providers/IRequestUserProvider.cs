using ProfileApi.Models.DTOs;

namespace ProfileApi.Providers
{
    public interface IRequestUserProvider
    {
        UserInfo? GetUserInfo();
    }
}
