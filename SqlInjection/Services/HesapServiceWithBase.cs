
using SqlInjection.DataAccess;
using SqlInjection.Models;
using System.Linq;

namespace SqlInjection.Services
{
    public interface IHesapService
    {
        string Giris(KullaniciGirisModel model);
    }
    public class HesapService : IHesapService
    {
        private Odev_DBContext _db = new Odev_DBContext();
        public string Giris(KullaniciGirisModel model)
        {
            string sonuc = "";
            var kullanici = _db.Kullanicilar.Where(k => k.KullaniciAdi == model.KullaniciAdi).FirstOrDefault();
            if (kullanici == null)
            {
                model.ErrorMessage = "Hatalı kullanıcı adı veya şifre !!!";
                sonuc = "Başarısız";
            }
            else
            {
                sonuc = "Başarılı";
            }
            return sonuc;
        }
    }
}

