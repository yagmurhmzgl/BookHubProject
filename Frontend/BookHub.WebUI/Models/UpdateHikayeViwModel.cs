using System.ComponentModel.DataAnnotations;

namespace BookHub.WebUI.Models
{
    public class UpdateHikayeViwModel
    {
        [Key]
        public int HikayeId { get; set; }
        public int KullaniciId { get; set; }
        public int KategoriId { get; set; }
        public int IcerikId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime YayınlamaTarihi { get; set; }
        public DateTime GüncellenmeTarihi { get; set; }
        public string GörüntülenmeSayisi { get; set; }
        public string BegeniSayısı { get; set; }
        public string YorumSayisi { get; set; }
    }
}
