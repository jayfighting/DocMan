using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Application.Contracts.Persistence
{
    public interface IDocumentTypeRepository : IAsyncRepository<DocumentType>
    {
        Task<bool> IsCategoryNameUnique(string name);
    }
}
