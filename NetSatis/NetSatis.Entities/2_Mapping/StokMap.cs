using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class StokMap:EntityTypeConfiguration<Stok>
    {
        public StokMap()
        {
            //primary key
            this.HasKey(p => p.Id);
            //ID kolonu otomatik artna şekilde olacak
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //max 12 karekterlik bir alan istedik
            this.Property(p => p.StokKodu).HasMaxLength(12);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.BarkodTürü).HasMaxLength(15);
            this.Property(p => p.Birimi).HasMaxLength(15);
            this.Property(p => p.StokGrubu).HasMaxLength(30);
            this.Property(p => p.StokAltGrup).HasMaxLength(30);
            this.Property(p => p.Marka).HasMaxLength(30);
            this.Property(p => p.Modeli).HasMaxLength(30);
            this.Property(p => p.OzelKod1).HasMaxLength(30);
            this.Property(p => p.OzelKod2).HasMaxLength(30);
            this.Property(p => p.GarantiSüresi).HasMaxLength(15);
            this.Property(p => p.UreticiKodu).HasMaxLength(20);
            this.Property(p => p.AlisFiyati1).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati1).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.MinStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.MaxStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            //veri tabanında tablonun ismi stoklar
            this.ToTable("Stoklar");
            //kolonların adı
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.BarkodTürü).HasColumnName("BarkodTürü");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.StokGrubu).HasColumnName("StokGrubu");
            this.Property(p => p.StokAltGrup).HasColumnName("StokAltGrup");
            this.Property(p => p.Marka).HasColumnName("Marka");
            this.Property(p => p.Modeli).HasColumnName("Modeli");
            this.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            this.Property(p => p.GarantiSüresi).HasColumnName("GarantiSüresi");
            this.Property(p => p.UreticiKodu).HasColumnName("UreticiKodu");
            this.Property(p => p.AlisKdv).HasColumnName("AlisKdv");
            this.Property(p => p.SatisKdv).HasColumnName("SatisKdv");
            this.Property(p => p.AlisFiyati1).HasColumnName("AlisFiyati1");
            this.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
            this.Property(p => p.SatisFiyati1).HasColumnName("SatisFiyati1");
            this.Property(p => p.SatisFiyati2).HasColumnName("SatisFiyati2");
            this.Property(p => p.MinStokMiktari).HasColumnName("MinStokMiktari");
            this.Property(p => p.MaxStokMiktari).HasColumnName("MaxStokMiktari");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");





        }
    }
}
