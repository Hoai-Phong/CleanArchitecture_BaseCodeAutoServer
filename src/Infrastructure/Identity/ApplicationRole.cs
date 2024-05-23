using Microsoft.AspNetCore.Identity;
using BaseCodeAutoSever.WebUi.Shared.Authorization;

namespace BaseCodeAutoSever.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
