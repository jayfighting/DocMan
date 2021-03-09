using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Application.Contracts.Persistence
{
    public interface IDocumentUserGroupRepository : IAsyncRepository<DocumentUserGroup>
    {
        public Task<bool> IsUserGroupNameUnique(string name);
    }
}
