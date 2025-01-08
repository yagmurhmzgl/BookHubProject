using System.ComponentModel.DataAnnotations;

namespace BookHub.WebUI.Dtos.AdmYazarDto
{
	public class CreateAdmYazarDto
	{
        [Required(ErrorMessage ="Yazar Adı Giriniz")]
        public string YazarAdi { get; set; }

		[Required(ErrorMessage = "Yazar Soyadı Giriniz")]
		public string YazarSoyadi { get; set; }
     
    
    }
}
