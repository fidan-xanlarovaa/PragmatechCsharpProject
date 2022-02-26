using System.ComponentModel.DataAnnotations;
using Blog.Shared.Localization;


namespace Blog.Entities.Dtos.Auth
{
    public class LoginDto
    {

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.Email))]
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.RequiredErrorMessage))]
        [MaxLength(100, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.MaxLengthErrorMessage))]
        [MinLength(10, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.MinLengthErrorMessage))]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.Password))]
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.RequiredErrorMessage))]
        [MaxLength(30, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.MaxLengthErrorMessage))]
        [MinLength(6, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.MinLengthErrorMessage))]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))] //(BaseLocalization.RememberMe))]
        public bool RememberMe { get; set; }
    }
}