using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
	public class Yazar
	{
		[Key]
		public int YazarId { get; set; }

		public string? YazarAdi { get; set; }

		public string? YazarSoyadi { get; set; }
	}
}
