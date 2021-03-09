using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Infrastructure.Docutech;

namespace LD.DocMan.Infrastructure.Vendors.Docutech
{
    public class DocutechPushbackSevice : IDocutechPushBackService
    {
        public async Task<bool> HandleDocutechPushback(string pushbackXml)
        {
            return true;
            //ToDo: Add Pushback Handler Logic Here
        }

    }
}
