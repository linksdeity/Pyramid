using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pyramid.Data
{
    public class TeamMember
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public bool DefaultTeamMember { get; set; } = true;
        public bool IsLocked { get; set; } = false;
        public int TeamMemberId { get; set; }
    }
}
