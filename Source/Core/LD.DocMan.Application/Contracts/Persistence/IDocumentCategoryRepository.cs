using LD.DocMan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LD.DocMan.Application.Contracts.Persistence
{
    public interface IDocumentCategoryRepository : IAsyncRepository<DocumentCategory>
    {
        Task<List<DocumentCategory>> GetCategoriesWithDocumentTypes();
    }
}
