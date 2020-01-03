using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberi.Entity
{
    public class Departman
    {
        public int DepartmanId { get; set; }
        public string DepartmanAdi{ get; set; }

        public ICollection<Calisan> Calisanlar { get; set; }
    }
}
