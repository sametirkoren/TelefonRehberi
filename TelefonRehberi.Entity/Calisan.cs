using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberi.Entity
{
    public class Calisan
    {
        public int CalisanId{ get; set; }
        public string CalisanAdi { get; set; }
        public string CalisanSoyadi { get; set; }
        public string Telefon{ get; set; }

        public int YoneticiId { get; set; }
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }
    }
}
