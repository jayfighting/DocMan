using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Persistence.Repositories
{
    public class DocumentCategoryRepository : BaseRepository<DocumentCategory>, IDocumentCategoryRepository
    {
        public DocumentCategoryRepository(DocManDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<DocumentCategory>> GetCategoriesWithDocumentTypes()
        {
            throw new NotImplementedException();
        }
    }
}
