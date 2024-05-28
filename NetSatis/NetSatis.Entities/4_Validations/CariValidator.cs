using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class CariValidator:AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari kodu alanı boş geçilemez");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari adı alanı boş geçilemez");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili kişi alanı boş geçilemez");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Cari kodu alanı boş geçilemez");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Girdiğiniz e mail adresi geçersiz");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto oranı alanı 0'dan küçük olamaz. ");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Ris limiti alanı 0'dan küçük olamaz. ");





        }
    }
}
