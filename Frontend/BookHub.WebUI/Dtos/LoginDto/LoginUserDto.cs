using BookHub.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace BookHub.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage="Kullanıcı Adını Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Passsword { get; set; }
        public AppUser UserName { get; internal set; }
    }
}
