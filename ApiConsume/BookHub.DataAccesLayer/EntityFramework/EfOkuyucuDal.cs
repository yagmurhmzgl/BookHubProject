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
    public class EfOkuyucuDal:GenericRepository<Okuyucu>,IOkuyucuDal
    {
        public EfOkuyucuDal(Context context):base(context)        {
                
        }
    }
}
