using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.DtoLayer.Dtos.HikayeDto
{
    public class UpdateHikayeDto
    {
        public int HikayeId { get; set; }
        public int İcerikId { get; set; }

        [Required(ErrorMessage = "Lütfen Hikaye Adı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Açıklama Giriniz")]
        public string Description { get; set; }
        public DateTime YayınlamaTarihi { get; set; }
        public DateTime GüncellenmeTarihi { get; set; }
        public string GörüntülenmeSayisi { get; set; }
        public string BegeniSayısı { get; set; }
        public string YorumSayisi { get; set; }
    }
}
