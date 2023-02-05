using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void TAdd(Student t)
        {
            _studentDal.Insert(t);
        }

        public void TDelete(Student t)
        {
            _studentDal.Delete(t);
        }

        public Student TGetByID(int id)
        {
            return _studentDal.GetById(id);
        }

        public List<Student> TGetList()
        {
            return _studentDal.GetList();
        }

        public List<Student> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Student t)
        {
            _studentDal.Update(t);
        }
    }
}
