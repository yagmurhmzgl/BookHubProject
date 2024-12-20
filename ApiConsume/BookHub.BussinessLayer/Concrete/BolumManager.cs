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
    public class BolumManager : IBolumService
    {
        private readonly IBolumDal _bolumDal;
        public BolumManager(IBolumDal bolumDal)
        {
            _bolumDal = bolumDal;
        }

        public void TDelete(Bolum t)
        {
            _bolumDal.Delete(t);
        }

        public Bolum TGetByID(int id)
        {
           return _bolumDal.GetByID(id);
        }

        public List<Bolum> TGetList()
        {
            return _bolumDal.GetList();
        }

        public void TInsert(Bolum t)
        {
            _bolumDal.Insert(t);
        }

        public void TUpdate(Bolum t)
        {
            _bolumDal.Update(t);
        }
    }
}
