using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AssignmentManager : IAssignmentService
    {
        IAssignmentDal _assignmentDal;

        public AssignmentManager(IAssignmentDal assignmentDal)
        {
            _assignmentDal = assignmentDal;
        }

        public void TAdd(Assignment t)
        {
            _assignmentDal.Insert(t);
        }

        public void TDelete(Assignment t)
        {
            _assignmentDal.Delete(t);
        }

        public Assignment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Assignment> TGetList()
        {
            return _assignmentDal.GetList();
        }

        public List<Assignment> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Assignment t)
        {
            _assignmentDal.Update(t);
        }
    }
}
