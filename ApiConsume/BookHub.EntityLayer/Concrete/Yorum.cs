using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        public int KullaniciId { get; set; }
        public int İcerikId { get; set; }
        public DateTime YayınlamaTarih {  get; set; }

    }
}
