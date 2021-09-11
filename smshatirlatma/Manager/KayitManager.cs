
using smshatirlatma.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smshatirlatma.Manager
{

    class KayitManager
    {
       OptikDbEntities veritabani = new OptikDbEntities();
      
        public void fonksiyon(string ad, string tel, DateTime zaman)
        {
            var parcala = soyadbul(ad);
            kayit kayit = new kayit();
            kayit.ad = parcala.ad;
            kayit.soyad = parcala.soyad;
            kayit.telefon = tel;
            kayit.alim = zaman;
            kayit.sonrakialim = zaman.AddYears(3);
          //  kayit.smsgonderim = false;

            veritabani.kayit.Add(kayit);
            veritabani.SaveChanges();

        }
        private (string ad, string soyad) soyadbul(string gelentext)
        {
            int uzunluk = gelentext.Length;
            string[] spl = gelentext.Split(' ');
            string soyad = spl[spl.Count() - 1];
            string ad = gelentext.Substring(0, uzunluk - soyad.Length);

            if (spl.Count() == 1) { ad = soyad; soyad = null; }
            return (ad, soyad);

        }
       
    }

}
