using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LD.DocMan.Application.Contracts.Infrastructure.Docutech
{
    public interface IDocutechRequestService
    {
        Task<bool> SendDocutechRequest(string requestXML);
        Task<string> CreateDocutechRequest(string jsonLoanData);
    }
}
