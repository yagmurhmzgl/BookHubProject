using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public string Name { get; set; }
        public string  Eposta { get; set; }
        public string Sifre {  get; set; }
        public string ProfilResmi { get; set; }
        public string Biyografi { get; set; }

    }
}
