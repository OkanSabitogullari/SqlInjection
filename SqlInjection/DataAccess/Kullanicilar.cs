using System;
using System.Collections.Generic;

namespace SqlInjection.DataAccess
{
    public partial class Kullanicilar
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
