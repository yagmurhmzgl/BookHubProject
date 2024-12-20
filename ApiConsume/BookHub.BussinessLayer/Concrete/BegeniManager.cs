using BookHub.BussinessLayer.Abstract;
using BookHub.DataAccesLayer.Abstract;
using BookHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.BussinessLayer.Concrete
{
    public class BegeniManager : IBegeniService
    {
        private readonly IBegeniDal _begeniDal;
        public BegeniManager(IBegeniDal begeniDal)
        {
            _begeniDal = begeniDal;
        }
        public void TDelete(Begeni t)
        {
            _begeniDal.Delete(t);
        }

        public Begeni TGetByID(int id)
        {
            return _begeniDal.GetByID(id);
        }

        public List<Begeni> TGetList()
        {
            return _begeniDal.GetList();
        }

        public void TInsert(Begeni t)
        {
            _begeniDal.Insert(t);
        }

        public void TUpdate(Begeni t)
        {
            _begeniDal.Update(t);
        }
    }
}
