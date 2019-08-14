using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pyramid.Data
{
    public class TaskSlot
    {
        public TeamMember AssignedTeamMember { get; set; }
        public bool LockedSlot { get; set; } = false;
    }
}
