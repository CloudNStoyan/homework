using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class Version : System.Attribute
    {
        private int major;
        private int minor;

        public Version(int versionMajor, int versionMinor)
        {
            this.major = versionMajor;
            this.minor = versionMinor;
        }

        public string GetVersion
        {
            get { return $"{this.major}.{this.minor}"; }
        }
    }
}
