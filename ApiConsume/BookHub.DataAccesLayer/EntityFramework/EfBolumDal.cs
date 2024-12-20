using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHub.DataAccesLayer.Abstract;
using BookHub.DataAccesLayer.Concrete;
using BookHub.DataAccesLayer.Repositories;
using BookHub.EntityLayer.Concrete;

namespace BookHub.DataAccesLayer.EntityFramework
{
    public class EfBolumDal:GenericRepository<Bolum>,IBolumDal
    {
        public EfBolumDal(Context context):base(context)
        {
                
        }
    }
}
