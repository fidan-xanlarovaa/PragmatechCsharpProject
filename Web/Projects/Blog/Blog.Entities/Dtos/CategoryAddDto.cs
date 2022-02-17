using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Dtos
{
    /// <summary>
    /// 
    /// Bunu yaradiriq cunnki,biz userden data alan zaman , ondan id , is deleted ve s. tipli melumatlari almiriq onlar basDTo-dan gelir.
    /// 
    /// </summary>
    public class CategoryAddDto 
    {
        /// <summary>
        /// 
        /// confiqurations of Name property
        /// 
        /// </summary>
        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]

        /// <summary>
        /// 
        ///  Name property itself
        /// 
        /// </summary>
         
        public string Name { get; set; } 

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(500, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Description { get; set; }

        // [Required(ErrorMessage = "{0} is required.")] // required olmadiqi ucun bu rowunu artiq istifade elemirik
        [MaxLength(500, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Note { get; set; }

        [DisplayName("Is active ?")]
        // [Required(ErrorMessage = "{0} is required.")] // required olmadiqi ucun bu rowunu artiq istifade elemirik

        public bool IsActive { get; set; }
    }
}