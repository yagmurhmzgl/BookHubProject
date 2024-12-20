using System;
using System.Collections.Generic;

namespace BookHub.EntityLayer.Concrete
{
	public class Bolumler
	{
		public int BolumId { get; set; }

		public int HikayeId { get; set; }

		public string Name { get; set; } = null!;

		public int Sira { get; set; }

		public DateTime YayınlanmaTarih { get; set; }
	}
}
