using BookHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.BussinessLayer.Abstract
{
	public interface IYazarService: IGenericService<Yazar>
	{
		public List<Yazar> GetAllYazarlar()
		{
			// Metotların içeriğini uygulayın
			return new List<Yazar>();
		}
	}
}
