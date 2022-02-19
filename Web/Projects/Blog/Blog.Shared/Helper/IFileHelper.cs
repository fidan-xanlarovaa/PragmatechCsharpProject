using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Blog.Shared.Helpers
{

    /// <summary>
    /// Isi yalniz fayl upload edib silmekden ibaretdir
    /// </summary>
    public interface IFileHelper
    {
        // 1. gondereceyimiz sekil, gondereceyimiz folder, sekle vereceyimiz yeni ad(bura userimizin adin yaza bilerikki sonradan
        // searchde axrtaranda tapmaq asan olsun)
        Task<IResult<FileDto>> UploadImageAsync(IFormFile file, string subDirectory, string otherName = default); 
        IResult<FileDto> DeleteImage(string fileName);
    }
}