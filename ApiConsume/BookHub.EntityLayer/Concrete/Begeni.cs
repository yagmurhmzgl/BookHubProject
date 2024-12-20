using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
    public class Begeni
    {
        [Key]
        public int BegeniId { get; set; }
        public int HikayeId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime BegeniTarih { get; set; }
    }
}
