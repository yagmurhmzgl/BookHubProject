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
    public class YorumManager : IYorumService
    {
        private readonly IYorumDal _yorumDal;
        public YorumManager(IYorumDal yorumDal)
        {
            _yorumDal = yorumDal;
        }
        public void TDelete(Yorum t)
        {
            _yorumDal.Delete(t);
        }

        public Yorum TGetByID(int id)
        {
           return _yorumDal.GetByID(id);
        }

        public List<Yorum> TGetList()
        {
           return _yorumDal.GetList();
        }

        public void TInsert(Yorum t)
        {
           _yorumDal.Insert(t);
        }

        public void TUpdate(Yorum t)
        {
            _yorumDal.Update(t);
        }
    }
}
