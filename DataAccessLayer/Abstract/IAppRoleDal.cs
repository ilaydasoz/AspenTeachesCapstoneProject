using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAppRoleDal : IGenericDal<AppRole>
    {
       int GetLoggedUserRoleId(int UserId);
    }
}
