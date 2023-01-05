using CRMProject.DTO.Pages;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.BL.Validation
{
    public class UserAccountDTOValidation : AbstractValidator<UserAccountDTO>
    {
        public UserAccountDTOValidation()
        {
            RuleFor(t0=>t0.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Bırakılamaz");
            RuleFor(t0 => t0.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz");
            RuleFor(t => t.FullName).NotEmpty().MaximumLength(255).WithMessage("Tam Ad kısmı boş bıraklamaz");
        }
    }
}
