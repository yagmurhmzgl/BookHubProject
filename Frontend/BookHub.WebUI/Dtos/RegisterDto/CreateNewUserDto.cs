using System.ComponentModel.DataAnnotations;

namespace BookHub.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Soyad Alanı Giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Kullanıcı Adı Alanı Giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Mail Alanı Giriniz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage ="Şifre Alanı Giriniz.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Giriniz.")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
