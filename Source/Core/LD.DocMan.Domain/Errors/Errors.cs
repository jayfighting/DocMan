using System;

namespace LD.DocMan.Domain.Errors
{
    public class Errors
    {
        public static class Document
        {
            public static Error DocumentIdNotFound(Guid id) =>
                new Error(ErrorCode.DocumentNotFound, $"Document is not found for {id}");
        }
        
    }
}