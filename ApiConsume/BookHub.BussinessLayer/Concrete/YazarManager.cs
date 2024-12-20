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
	public class YazarManager: IYazarService
	{
		private readonly IYazarDal _yazarDal;
		public YazarManager(IYazarDal yazarDal)
		{
			_yazarDal = yazarDal;
		}

		public void TDelete(Yazar t)
		{
			_yazarDal.Delete(t);
		}

		public Yazar TGetByID(int id)
		{
			return _yazarDal.GetByID(id);
		}

		public List<Yazar> TGetList()
		{
			return _yazarDal.GetList();
		}

		public void TInsert(Yazar t)
		{
			_yazarDal.Insert(t);
		}

		public void TUpdate(Yazar t)
		{
			_yazarDal.Update(t);
		}
	}
}

