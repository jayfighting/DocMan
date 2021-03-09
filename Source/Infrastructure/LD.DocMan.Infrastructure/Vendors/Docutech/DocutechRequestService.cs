using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Infrastructure.Docutech;

namespace LD.DocMan.Infrastructure.Vendors.Docutech
{
    public class DocutechRequestService : IDocutechRequestService
    {
        public async Task<bool> SendDocutechRequest(string requestXML)
        {
            return true;
            //ToDo: Add Docutech Request Logic Here
        }

        public async Task<string> CreateDocutechRequest(string jsonLoanData)
        {
            return String.Empty;
            //ToDo: Add Request XML Creation logic
        }
    }
}
