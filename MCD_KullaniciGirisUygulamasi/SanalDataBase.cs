using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KullaniciGirisUygulamasi
{
    public class SanalDataBase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();

        static SanalDataBase()
        {
            KullaniciTablo.Add(new Kullanici()
            {
                id=1,
                isim="Gamze",
                soyisim="Kural",
                kullaniciAdi="gamze.kural",
                sifre="1",
                aciklama="Gamze Kural kullanıcı profil bilgisi"
            });

            KullaniciTablo.Add(new Kullanici()
            {
                id = 2,
                isim = "Elif",
                soyisim = "Kural",
                kullaniciAdi = "elif.kural",
                sifre = "2",
                aciklama = "Elif Kural kullanıcı profil bilgisi"
            });
        }
    }
    
}
