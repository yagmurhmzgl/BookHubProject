using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.EntityLayer.Concrete
{
    public class Bolum
    {
        [Key]
        
        public int BolumId { get; set; }
        public int HikayeId { get; set; }
        public string Name {  get; set; }
        public int Sira {  get; set; }
        public DateTime YayınlanmaTarih {  get; set; }
    }
}
