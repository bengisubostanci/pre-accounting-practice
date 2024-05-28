using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities._6_Interfaces;

namespace NetSatis.Entities.Tables
{
    public class Fis:IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Tarih { get; set; }
        public string PlasiyerKodu { get; set; }
        public string PlasiyerAdi { get; set; }
        public decimal IskontoOrani { get; set; }
        public decimal IskontoTutari { get; set; }
        public decimal ToplamTutar { get; set; }
        public string Açiklama { get; set; }
        
    }
}
