using System.Collections.Generic;
using LD.DocMan.Domain.Common;

namespace LD.DocMan.Domain.Errors
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