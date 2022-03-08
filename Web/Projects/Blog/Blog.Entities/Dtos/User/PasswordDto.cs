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

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.CurrentPassword))]//
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.RequiredErrorMessage))]//
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.MaxLengthErrorMessage1))]//
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.MinLengthErrorMessage1))]//BaseLocalization.MinLengthErrorMessage
        public string CurrentPassword { get; set; }


        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NewPassword))]//BaseLocalization..Username
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.RequiredErrorMessage))]//BaseLocalization.RequiredErrorMessage
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.MaxLengthErrorMessage1))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.MinLengthErrorMessage1))]//BaseLocalization.MinLengthErrorMessage

        public string NewPassword { get; set; }


        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.ConfirmNewPassword))]//BaseLocalization..Username
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.RequiredErrorMessage))]//BaseLocalization.RequiredErrorMessage
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.MaxLengthErrorMessage1))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.MinLengthErrorMessage1))]//BaseLocalization.MinLengthErrorMessage
        [Compare("NewPassword", ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NotMatched))]//BaseLocalization.MinLengthErrorMessage
        
        public string ConfirmNewPassword { get; set; }
    }
}
