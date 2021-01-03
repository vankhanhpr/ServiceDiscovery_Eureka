using ModelClassLibrary.area.auth.roles;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using WebApi.reponsitory;

namespace ModelClassLibrary.permission.services
{
    public interface IUserPermission: IReponsitory<Permissions>
    {
        Boolean checkPermissionForUser(ClaimsPrincipal user, string permission);
    }
}
