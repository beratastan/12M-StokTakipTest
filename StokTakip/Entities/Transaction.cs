using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    internal class Transaction
    {
        public Int64 SiraNo { get; set; }
        public string Tur { get; set; }
        public string MalKodu { get; set; }
        public string EvrakNo { get; set; }
        public string Tarih { get; set; }
        public decimal GirisMiktar { get; set; }
        public decimal CikisMiktar { get; set; }
        public decimal Stok { get; set; }
    }
}
