using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Commands.UpdateDocumentUserGroup
{
    public class UpdateDocumentUserGroupCommand : IRequest
    {
        public Guid UserGroupId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
