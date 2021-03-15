namespace LD.DocMan.Domain.Common
{
    public class ErrorCode : Enumeration
    {
        public static ErrorCode NotFound = new ErrorCode(1, nameof(NotFound).ToLowerInvariant()); 
        public ErrorCode(int id, string name) : base(id, name)
        {
        }
    }
}