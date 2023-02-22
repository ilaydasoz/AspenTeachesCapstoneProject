using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IRoleService : IGenericService<AppRole>
    {
        int TGetLoggedUserRoleId(int UserId);
    }
}
