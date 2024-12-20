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
    public class EfKategoriDal:GenericRepository<Kategori>,IKategoriDal
    {
        public EfKategoriDal(Context context):base(context)       {
                
        }
    }
}
