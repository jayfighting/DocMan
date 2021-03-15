using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Persistence.Repositories
{
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(DocManDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> DocumentTypeExists(Guid documentTypeId)
        {
            var documentType = _dbContext.DocumentTypes.Any(dt => dt.Id == documentTypeId);
            return Task.FromResult(documentType);
        }
    }
}
