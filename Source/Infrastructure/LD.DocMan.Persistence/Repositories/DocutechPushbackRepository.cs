using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Application.Models.ThirdParty.Docutech;

namespace LD.DocMan.Persistence.Repositories
{
    public class DocutechPushbackRepository : BaseRepository<DocutechPushback>, IDocutechPushbackRepository
    {
        public DocutechPushbackRepository(DocManDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> Validate()
        {
            return true;
            //ToDo: Impliment Validation Logic
        }
    }
}
