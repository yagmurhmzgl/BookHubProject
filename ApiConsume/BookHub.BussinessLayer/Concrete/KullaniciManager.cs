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
    public class KullaniciManager : IKullaniciService
    {
        private readonly IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
        public void TDelete(Kullanici t)
        {
            _kullaniciDal.Delete(t);
        }

        public Kullanici TGetByID(int id)
        {
            return _kullaniciDal.GetByID(id);
        }

        public List<Kullanici> TGetList()
        {
            return _kullaniciDal.GetList();
        }

        public void TInsert(Kullanici t)
        {
            _kullaniciDal.Insert(t);
        }

        public void TUpdate(Kullanici t)
        {
            _kullaniciDal.Update(t);
        }



    }
}
