using System.ComponentModel.DataAnnotations;
using Blog.Shared.Localization;
using Microsoft.AspNetCore.Http;

namespace Blog.Entities.Dtos.User
{
    public class UserAddDto
    {
        //[DisplayName("Category Name")] evezine Display istifade eledik, Display istifade eden zaman biz onu sourcesini
        //yeni hardan oxuyacaqini ve hansi adi gostermelidise onu yeni atributunu vermeliyik
       
        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))]// nameof(BaseLocalization.UserName))]
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.RequiredErrorMessage))]
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MaxLengthErrorMessage))]
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MinLengthErrorMessage))]
        public string UserName { get; set; }

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.Email))]
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.RequiredErrorMessage))]
        [MaxLength(100, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MaxLengthErrorMessage))]
        [MinLength(10, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MinLengthErrorMessage))]
        [DataType(DataType.EmailAddress, ErrorMessage = "")]
        public string Email { get; set; }

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.Password))]
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.RequiredErrorMessage))]
        [MaxLength(30, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MaxLengthErrorMessage))]
        [MinLength(6, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MinLengthErrorMessage))]
        [DataType(DataType.Password)] //Pasword olub plmamasin yoxlayir
        public string Password { get; set; }
        /// <summary>
        /// +99455 666 66 66
        /// </summary>
        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.PhoneNumber))]
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.RequiredErrorMessage))]
        [MaxLength(13, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MaxLengthErrorMessage))]
        [MinLength(13, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))] //nameof(BaseLocalization.MinLengthErrorMessage))]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Upload)] //faylin yuklenib yuklenmemesini yoxlayir
        public IFormFile File { get; set; }
    }
}