using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
    public class Okuyucu
    {
        [Key]
        public int OkuyucuId { get; set; }
        public int KullaniciId { get; set; }
        public int HikayeId { get; set; }
        public DateTime BitisTarih {  get; set; }
        public DateTime SonNokta {  get; set; }

    }
}
