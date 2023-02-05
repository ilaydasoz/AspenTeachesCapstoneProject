using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public Project TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> TGetList()
        {
            return _projectDal.GetList();
        }

        public List<Project> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
