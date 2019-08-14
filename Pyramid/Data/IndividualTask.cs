using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pyramid.Data
{
    public class IndividualTask
    {
        public string TaskName { get; set; }
        public string Color { get; set; }
        public List<TeamMember> AssignedTeamMembers { get; set; }
        public bool DefaultTask { get; set; } = true;
        public int TaskId { get; set; }
        public int SlotNumber { get; set; }
    }
}
