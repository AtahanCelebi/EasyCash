    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    namespace EashCashIdentityProject.DtoLayer.Dtos.AppUserDto;
    public class AppUserRegisterDto
    {
        /*[Required(ErrorMessage = "Ad alanı zorunludur")]
        [Display(Name = "İsim:")]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter girilebilir.")] */
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }