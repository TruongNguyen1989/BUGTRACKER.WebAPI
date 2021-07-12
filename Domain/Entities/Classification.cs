using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Classification : AuditableBaseEntity<int>
    {
        public string ClassificationName { get; set; }
        public string Description { get; set; }
        public IEnumerable<BugInfomation> BugInfomations { get; set; }
    }
}
