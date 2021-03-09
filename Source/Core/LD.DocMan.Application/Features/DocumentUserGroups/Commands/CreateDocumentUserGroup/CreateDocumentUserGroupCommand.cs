using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Commands.CreateDocumentUserGroup
{
    public class CreateDocumentUserGroupCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
