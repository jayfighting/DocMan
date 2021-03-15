using LD.DocMan.Domain.Common;

namespace LD.DocMan.Domain.Errors
{
    public class ErrorCode : Enumeration
    {
        public static ErrorCode DocumentNotFound = new ErrorCode(1, nameof(DocumentNotFound).ToLowerInvariant()); 
        public ErrorCode(int id, string name) : base(id, name)
        {
        }
    }
}