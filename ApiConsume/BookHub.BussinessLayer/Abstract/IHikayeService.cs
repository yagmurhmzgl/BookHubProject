using BookHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.BussinessLayer.Abstract
{
    public interface IHikayeService:IGenericService<Hikaye>
    {
		IEnumerable<object> GetAll();

		public List<Hikaye> GetAllHikayeler()
        {
            // Metotların içeriğini uygulayın
            return new List<Hikaye>();

        }
		List<Hikaye> GetHikayelerByKategori(int kategoriId);
	}
}
