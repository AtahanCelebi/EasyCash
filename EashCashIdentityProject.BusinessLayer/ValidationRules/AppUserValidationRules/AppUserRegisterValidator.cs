using FluentValidation;
using EashCashIdentityProject.DtoLayer.Dtos;
using EashCashIdentityProject.DtoLayer.Dtos.AppUserDto;
public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDto>
{
    public AppUserRegisterValidator()
    {   
        RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Olamaz.");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş olamaz");
        RuleFor(x => x.Username).NotEmpty().WithMessage(" boş olamaz");
        RuleFor(x => x.Email).NotEmpty().WithMessage(" boş olamaz");
        RuleFor(x => x.Password).NotEmpty().WithMessage(" boş olamaz");
        RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("boş olamaz");
        RuleFor(x => x.Name).MaximumLength(30).WithMessage("maksimum 30 karakter");
        RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parola eşleşmiyor.");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir e-mail adresi giriniz.");
    }
}