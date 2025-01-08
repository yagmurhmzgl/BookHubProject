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
    public class HikayeManager : IHikayeService
    {
        private readonly IHikayeDal _hikayeDal;
        public HikayeManager(IHikayeDal hikayeDal)
        {
            _hikayeDal = hikayeDal;
        }

		public IEnumerable<object> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<Hikaye> GetHikayelerByKategori(int kategoriId)
		{
			return _hikayeDal.GetList()
				.Where(h => h.KategoriId == kategoriId)
				.ToList(); // Kategoriye göre filtreleme
		}

		public void TDelete(Hikaye t)
        {
            _hikayeDal.Delete(t);
        }

        public Hikaye TGetByID(int id)
        {
            return _hikayeDal.GetByID(id);
        }

        public List<Hikaye> TGetList()
        {
            return _hikayeDal.GetList();
        }

        public void TInsert(Hikaye t)
        {
            _hikayeDal.Insert(t);
        }

        public void TUpdate(Hikaye t)
        {
           _hikayeDal.Update(t);
        }
    }
}
