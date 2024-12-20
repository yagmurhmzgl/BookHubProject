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
 public class BultenManager:IBultenService
	{
		private readonly IBultenDal _bultenDal;
		public BultenManager(IBultenDal bultenDal)
		{
			_bultenDal = bultenDal;
		}

		public void TDelete(Bulten t)
		{
			_bultenDal.Delete(t);
		}

		public Bulten TGetByID(int id)
		{
			return _bultenDal.GetByID(id);
		}

		public List<Bulten> TGetList()
		{
			return _bultenDal.GetList();
		}

		public void TInsert(Bulten t)
		{
			_bultenDal.Insert(t);
		}

		public void TUpdate(Bulten t)
		{
			_bultenDal.Update(t);
		}
	}
}

