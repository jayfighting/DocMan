using System.Collections.Generic;

namespace LD.DocMan.Domain.Common
{
    public sealed class Error : ValueObject
    {
        public ErrorCode Code { get; }
        public string Message { get; }

        public Error(ErrorCode code, string message)
        {
            Code = code;
            Message = message;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
        }
    }
}