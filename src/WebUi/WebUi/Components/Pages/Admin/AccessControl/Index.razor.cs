using MediatR;
using Microsoft.AspNetCore.Components;
using BaseCodeAutoSever.Application.AccessControl.Commands;
using BaseCodeAutoSever.Application.AccessControl.Queries;
using BaseCodeAutoSever.WebUi.Shared.AccessControl;
using BaseCodeAutoSever.WebUi.Shared.Authorization;

namespace BaseCodeAutoSever.WebUi.Components.Pages.Admin.AccessControl;

public partial class Index
{
    [Inject] private IMediator Mediator { get; set; } = default!;
    
    private AccessControlVm? Model { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Model = await Mediator.Send(new GetAccessControl());
    }

    private async Task Set(RoleDto role, Permissions permission, bool granted)
    {
        role.Set(permission, granted);

        await Mediator.Send(new UpdateAccessControlCommand(role.Id, role.Permissions));
    }
}
