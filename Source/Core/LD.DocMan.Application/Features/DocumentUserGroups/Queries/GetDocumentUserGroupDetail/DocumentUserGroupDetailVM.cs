using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Queries.GetDocumentUserGroupDetail
{
    public class DocumentUserGroupDetailVM
    {
        public Guid UserGroupId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedByName { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
