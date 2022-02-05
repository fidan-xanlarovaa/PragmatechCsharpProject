using System.Threading.Tasks;
using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Abstract;

namespace Blog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> GetAsync(int id);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();

        /// <summary>
        /// evvel burda <IResult> tipini vermisdik amma ajjaxdan istifade edeceyimiz ucun (ajjax geriye data qaytarmalidir) tipini <IDataResult> olaraq deyisdik
        /// </summary>
        
        
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto dto, string createdByName);
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto dto, string createdByName);
        Task<IDataResult<CategoryUpdateDto>> GetUpdateDtoAsync(int id);
        Task<IDataResult<CategoryDto>> DeleteAsync(int id, string modifiedByName);
        Task<IResult> HardDeleteAsync(int id);
    }
}

/// <summary>
/// 
/// ajjaxin mentiqi 
/// her seyde sehife refresh getmesin 
/// controllerden ozu datalari goturur post get actionlarini elemek olur
/// 
/// </summary>


/// <summary>
/// 
/// Git version controllerdir.(GitHub, GitLab ve s.)
/// 
/// version controller ne demekdir? Oyun oynayareken biz level kecirik, her biz leveli kecdikce oyun o leveli yadda saxlayir ve biz novbeti defe 
/// daxil olanda o levelden baslayiriq.Yeniden baslamiriq. Git de bir nov bu mentiqle isleyir
/// Niye istifade edirik?
/// 1. kodumuzu .zip etmeli olmuruq, istenilen yerde istenilen kompla baxa bilirik
/// 2. kodu versiyalasdiririq ( commitler ile) bug olanda dala qaytarmaqa komek edir.
/// 3. local(compda olan) remote(web de olan)
/// 
/// </summary>

/// <summary>
/// 
/// Automapperi Core yox bura yuklemeyimizin sebebi proyekti daha qlobal etmekdi, gelcekde eger Web yox winform yazsaqda rahatliqla istifade ede bilek
/// 
/// </summary>


