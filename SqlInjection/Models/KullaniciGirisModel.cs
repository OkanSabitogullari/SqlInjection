using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SqlInjection.Models
{
    public class KullaniciGirisModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} gereklidir!")]
        [MaxLength(50, ErrorMessage = "{0} en çok {1} karakter olmalıdır!")]
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "{0} gereklidir!")]
        [StringLength(50, ErrorMessage = "{0} en fazla {1} karakter olmalıdır!")]
        [DisplayName("Şifre")]
        public string Sifre { get; set; }
        public string ErrorMessage { get; set; }
    }
}
