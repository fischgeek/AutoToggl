using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogglConnect;

namespace DesktopProjectDataHandler
{
    public class TrackedProject : Project
    {
        public int position { get; set; }
        public string[] projectKeywords { get; set; }
    }
}
