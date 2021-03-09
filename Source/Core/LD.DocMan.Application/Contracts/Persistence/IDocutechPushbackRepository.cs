using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Models.ThirdParty.Docutech;


namespace LD.DocMan.Application.Contracts.Persistence
{
    public interface IDocutechPushbackRepository : IAsyncRepository<DocutechPushback>
    {
        Task<bool> Validate();
    }
}
