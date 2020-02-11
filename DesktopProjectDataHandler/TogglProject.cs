using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProjectDataHandler
{
    public class TrackedProject
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public List<ProjectKeyword> ProjectKeywords { get; set; }
    }
}
