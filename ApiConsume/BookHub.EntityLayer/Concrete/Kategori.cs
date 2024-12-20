using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
    public class Kategori
    {
        [Key]
		public int KategoriId { get; set; }

		public string Name { get; set; } = null!;

		public string Aciklama { get; set; } = null!;
	}
}
