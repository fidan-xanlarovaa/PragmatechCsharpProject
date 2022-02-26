using Blog.Shared.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Dtos.User
{
    public class PasswordDto
    {
        [Required]
        public int Id { get; set; }

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization..Username
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.RequiredErrorMessage
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MinLengthErrorMessage
        public string CurrentPassword { get; set; }


        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization..Username
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.RequiredErrorMessage
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MinLengthErrorMessage

        public string NewPassword { get; set; }


        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization..Username
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.RequiredErrorMessage
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MinLengthErrorMessage
        [Compare("NewPassword", ErrorMessage = "Confirm new password does not match")]
        public string ConfirmNewPassword { get; set; }
    }
}
