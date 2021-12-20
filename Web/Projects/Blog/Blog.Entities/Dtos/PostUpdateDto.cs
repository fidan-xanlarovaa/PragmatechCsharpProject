using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Dtos
{
    public class PostUpdateDto
    {
        public int Id;

        [DisplayName("User Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public int UserId { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public int CategoryId { get; set; }

        [DisplayName("Post Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Title { get; set; }

        [DisplayName("Post Content")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Content { get; set; }

        [DisplayName("Post Thubnail")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Thumbnail { get; set; }

        [DisplayName("Post Date")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public DateTime Date { get; set; }

        [DisplayName("Post Seo Author")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string SeoAuthor { get; set; }

        [DisplayName("Post Seo Description")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string SeoDescription { get; set; }

        [DisplayName("Post Seo Tags")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string SeoTags { get; set; }

        [DisplayName("Note")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(500, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Note { get; set; }

        [DisplayName("Is active ?")]
        [Required(ErrorMessage = "{0} is required.")]
        public bool IsActive { get; set; }

        [DisplayName("Is deleted ?")]
        [Required(ErrorMessage = "{0} is required.")]
        public bool IsDeleted { get; set; }

    }
}
