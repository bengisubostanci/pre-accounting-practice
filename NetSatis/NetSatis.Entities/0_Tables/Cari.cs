﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities._6_Interfaces;

namespace NetSatis.Entities.Tables
{
    public class Cari:IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string CariTuru { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string YetkiliKisi { get; set; }
        public string FaturaUnvani { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string CariGrubu { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public decimal IskontoOrani { get; set; }
        public decimal RiskLimiti { get; set; }
        public string AlisOzelFiyati { get; set; }
        public string SatisOzelFiyati { get; set; }
        public string Aciklama { get; set; }
    }
}
