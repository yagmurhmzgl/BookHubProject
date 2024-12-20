namespace BookHub.WebUI.Models.Hikaye
{
    public class Hikaye
    {
        public int HikayeId { get; set; }
        public int KullaniciId { get; set; }
        public int KategoriId { get; set; }
        public int IcerikId { get; set; }
        public string Name { get; set; }
        public DateTime YayınlamaTarihi { get; set; }
        public DateTime GüncellenmeTarihi { get; set; }
        public int GörüntülenmeSayisi { get; set; }
        public string BegeniSayısı { get; set; }
        public string YorumSayisi { get; set; }
    }
}
