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
    public class OkuyucuManager : IOkuyucuService
    {
        private readonly IOkuyucuDal _okuyucuDal;
        public OkuyucuManager(IOkuyucuDal okuyucuDal)
        {
            _okuyucuDal = okuyucuDal;
        }
        public void TDelete(Okuyucu t)
        {
            _okuyucuDal.Delete(t);
        }

        public Okuyucu TGetByID(int id)
        {
           return _okuyucuDal.GetByID(id);
        }

        public List<Okuyucu> TGetList()
        {
            return _okuyucuDal.GetList();
        }

        public void TInsert(Okuyucu t)
        {
            _okuyucuDal.Insert(t);
        }

        public void TUpdate(Okuyucu t)
        {
            _okuyucuDal.Update(t);
        }
    }
}
