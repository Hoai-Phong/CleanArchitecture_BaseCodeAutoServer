using BaseCodeAutoSever.WebUi.Shared.AccessControl;

namespace BaseCodeAutoSever.WebUi.Client.Handlers.Interfaces;

public interface IUserHandler
{
    Task<UserDetailsVm> GetUserAsync(string userId);
    Task PutUserAsync(string userId, UserDto user);
}
