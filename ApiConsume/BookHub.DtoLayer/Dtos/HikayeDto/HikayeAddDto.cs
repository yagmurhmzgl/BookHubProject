using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.DtoLayer.Dtos.HikayeDto
{
    public class HikayeAddDto
    {
        public int İcerikId { get; set; }

        [Required(ErrorMessage = "Lütfen Hikaye Giriniz")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter girişi yapınız.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Açıklama Giriniz")]
        [StringLength(200, ErrorMessage = "Lütfen en fazla 200 karakter girişi yapınız.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen Hikaye Görseli Giriniz")]
        public string HikayeCoverImage { get; set; }
        public DateTime YayınlamaTarihi { get; set; }
        public DateTime GüncellenmeTarihi { get; set; }
        public string GörüntülenmeSayisi { get; set; }
        public string BegeniSayısı { get; set; }
        public string YorumSayisi { get; set; }
    }
}
