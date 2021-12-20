
using Blog.Shared.Utilities.ComplexTypes;

namespace Blog.Shared.Entities.Abstract
{
    public abstract class GetBaseDto
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}