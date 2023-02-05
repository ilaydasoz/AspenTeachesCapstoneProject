using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public Service TGetByID(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }

        public List<Service> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
