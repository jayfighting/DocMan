using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LD.DocMan.Application.Contracts.Infrastructure.Docutech
{
    public interface IDocutechPushBackService
    {
        Task<bool> HandleDocutechPushback(string pushbackXml);
    }
}
