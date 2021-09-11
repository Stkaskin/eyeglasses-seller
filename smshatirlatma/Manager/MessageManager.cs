using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smshatirlatma.Manager
{
   public class MessageManager
    {
        class smsapi
        {
            public string kno { get; set; }
            public string kad { get; set; }
            public string ksifre { get; set; }
            public string orjinator { get; set; }
        }
        private void mesajkomutu()
        {
            //MessageManager sms =new MessageManager();
            //System.Threading.Thread.Sleep(60000);
            //string mesaj = "<telmesaj><tel> 05469359716</tel><mesaj> mesajım </mesaj></telmesaj>"+
            //sms.gonder(mesaj);
        }
        public     void gonder(string numaramesaj)
        {
            string kno = "apikod", kad = "apiad", ksifre = "apiparola", orjinator = "api ad";

            string tur = "Normal";
            tur = "Turkce";
            string smsNN = "data=<sms><kno>" + kno + "</kno><kulad>" + kad + "</kulad><sifre>" + ksifre + "</sifre>" +
            "<gonderen>" + orjinator + "</gonderen>" +
            "<telmesajlar>" + numaramesaj +

            "</telmesajlar>" +
            "<tur>" + tur + "</tur></sms>";
            //MessageBox.Show("\n" + smsNN);
              string cevap = XmlPost("http://panel.xxsmscompany.com/panel/smsgonderNNpost.php", smsNN);
             MessageBox.Show(cevap);
        }

        private string XmlPost(string PostAddress, string xmlData)
        {
            using (WebClient wUpload = new WebClient())
            {
                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }
        }
    }
}
