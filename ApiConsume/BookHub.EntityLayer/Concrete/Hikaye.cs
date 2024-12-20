using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
    public class Hikaye
    {
		public int HikayeId { get; set; }

		public int KullaniciId { get; set; }

		public int KategoriId { get; set; }

		public string Name { get; set; } = null!;

		public string Decription { get; set; } = null!;

		public string HikayeCoverImage { get; set; } = null!;

	}
}
