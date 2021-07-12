using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BugInfomation : AuditableBaseEntity<int>
    {
        public int IssueTypeId { get; set; }
        public IssueType IssueType { get; set; }
        public int? ClassificationId { get; set; }
        public Classification Classification { get; set; }
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        public int RepId { get; set; }
        public Reproducible Reproducible { get; set; }
        public string StepsToReproduce { get; set; }
    }
}
