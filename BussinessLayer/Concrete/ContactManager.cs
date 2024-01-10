using System;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BussinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(Category entity)
        {
            _aboutDal.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _aboutDal.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _aboutDal.GetListAll();
        }

        public void TUpdate(Category entity)
        {
            _aboutDal.Update(entity);
        }
    }
}

