using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public List<string> UserGroups { get; set; }
    }
}
