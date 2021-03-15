using System;

namespace LD.DocMan.Domain.Common
{
    public class Errors
    {
        public static class Document
        {
        }

        public class General
        {
            public static Error NotFound() => new Error(ErrorCode.NotFound, $"Not Found");
        }
    }
}