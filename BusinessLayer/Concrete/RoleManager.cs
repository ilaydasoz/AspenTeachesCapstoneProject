using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IAppRoleDal _roleDal;

        public RoleManager(IAppRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void TAdd(AppRole t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppRole t)
        {
            throw new NotImplementedException();
        }

        public AppRole TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppRole> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<AppRole> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public int TGetLoggedUserRoleId(int UserId)
        {
            return _roleDal.GetLoggedUserRoleId(UserId);
        }

        public void TUpdate(AppRole t)
        {
            throw new NotImplementedException();
        }
    }
}
