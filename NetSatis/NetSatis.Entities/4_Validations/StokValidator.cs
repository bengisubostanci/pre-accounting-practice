using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class StokValidator:AbstractValidator<Stok>
    {
        public StokValidator()
        {
            //bazen alış fiyatına 0 ya da bir şey girmeyiz. varsayılan değeri 0 yaptık

            //RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok kodu alanı boş geçilemez");
           // RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok adı alanı boş geçilemez").Length(5,50)
             //   .WithMessage("Stok adı alanı 5 ile 50 karakter arasında olabilir");
            //RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod alanı boş geçilemez");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı-1 alanı 0'dan küçük olamaz. ");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı-2 alanı 0'dan küçük olamaz. ");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı-1 alanı 0'dan küçük olamaz. ");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı-2 alanı 0'dan küçük olamaz. ");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı-1 alanı 0'dan küçük olamaz. ");




        }
    }
}
