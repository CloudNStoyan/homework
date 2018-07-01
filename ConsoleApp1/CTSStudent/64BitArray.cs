using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSStudent
{
    class BitArray64
    {
        private ulong[] values;

        public BitArray64(params ulong[] values)
        {
            this.values = values;
        }
    }
}
