using System;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAppRoleDal : GenericRepository<AppRole>, IAppRoleDal
    {
        public int GetLoggedUserRoleId(int UserId)
        {
            using var c = new Context();
            var loggedUserRoleId = c.UserRoles.Where(x => x.UserId == UserId).Select(y => y.RoleId).FirstOrDefault();
            return loggedUserRoleId;
        }
    }
}
