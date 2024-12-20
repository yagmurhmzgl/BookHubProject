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
    public class KategoriManager : IKategoriService
    {
        private readonly IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }
        public void TDelete(Kategori t)
        {
            _kategoriDal.Delete(t);
        }

        public Kategori TGetByID(int id)
        {
            return _kategoriDal.GetByID(id);
        }

        public List<Kategori> TGetList()
        {
            return _kategoriDal.GetList();
        }

        public void TInsert(Kategori t)
        {
            _kategoriDal.Insert(t);
        }

        public void TUpdate(Kategori t)
        {
            _kategoriDal.Update(t);
        }
    }
}
