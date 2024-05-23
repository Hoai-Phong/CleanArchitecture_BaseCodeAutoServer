using MediatR;
using BaseCodeAutoSever.Application.Users.Commands;
using BaseCodeAutoSever.Application.Users.Queries;
using BaseCodeAutoSever.WebUi.Client.Handlers.Interfaces;
using BaseCodeAutoSever.WebUi.Shared.AccessControl;

namespace BaseCodeAutoSever.WebUi.Client.Handlers.ServerImplementation;

internal class UserServerHandler : IUserHandler
{
    private readonly IMediator _mediator;

    public UserServerHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task<UserDetailsVm> GetUserAsync(string userId)
    {
        return _mediator.Send(new GetUserQuery(userId));
    }

    public Task PutUserAsync(string userId, UserDto user)
    {
        return _mediator.Send(new UpdateUserCommand(user));
    }
}
