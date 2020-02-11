using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProjectDataHandler
{
    public class StoredData
    {
        public Settings Settings = new Settings();
        public List<TrackedProject> TrackedProjects = new List<TrackedProject>();
        private static StoredData instance = new StoredData();

        private StoredData() { }

        public static StoredData GetInstance() {
            return instance;
        }
    }
}
