using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void TAdd(Instructor t)
        {
            _instructorDal.Insert(t);
        }

        public void TDelete(Instructor t)
        {
            _instructorDal.Delete(t);
        }

        public Instructor TGetByID(int id)
        {
            return _instructorDal.GetById(id);
        }

        public List<Instructor> TGetList()
        {
            return _instructorDal.GetList();
        }

        public List<Instructor> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Instructor t)
        {
            _instructorDal.Update(t);
        }
    }
}
