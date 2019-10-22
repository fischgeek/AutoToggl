using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProjectDataHandler
{
    public class Settings
    {
        public bool StartWithWindows { get; set; } = true;
        public bool ShowOnStart { get; set; } = true;
        public bool CloseToTray { get; set; } = true;
        public int CheckInterval { get; set; } = 3000;
        public string TogglUsername { get; set; }
        public string TogglPassword { get; set; }
        public string TogglAPIKey { get; set; }
        public int TogglWorkspaceId { get; set; }
    }
}
