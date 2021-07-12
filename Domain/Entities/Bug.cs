using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bug : AuditableBaseEntity<int>
    {
        public string BugTitle { get; set; }
        public string Description { get; set; }
        public string AssignTo { get; set; }
        public string Followers { get; set; }
        public int MilestoneId { get; set; }
        public Milestone Milestone { get; set; }
    }
}
