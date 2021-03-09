using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Persistence.Repositories
{
    public class DocumentTypeRepository : BaseRepository<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository(DocManDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsCategoryNameUnique(string name)
        {
            var duplicates = _dbContext.DocumentCategories.Any(dup => dup.Name == name);
            return Task.FromResult(duplicates);
        }
    }
}
