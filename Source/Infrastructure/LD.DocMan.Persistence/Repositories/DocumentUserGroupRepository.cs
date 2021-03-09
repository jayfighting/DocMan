using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Persistence.Repositories
{
    public class DocumentUserGroupRepository : BaseRepository<DocumentUserGroup>, IDocumentUserGroupRepository
    {
        public DocumentUserGroupRepository(DocManDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> IsUserGroupNameUnique(string name)
        {
            return true;
            //ToDo: Add Unique Logic
        }
    }
}
