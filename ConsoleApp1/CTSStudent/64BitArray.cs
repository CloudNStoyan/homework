using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Count = this.values.Length;
        }

        public ulong this[int index]
        {
            get { return this.values[index]; }
            set { this.values[index] = value; }
        }

        public static bool operator ==(BitArray64 first,BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public int Count { get; private set; }

        public override bool Equals(object obj)
        {
            BitArray64 other = (BitArray64)obj;
            if (this.Count == other.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i] != other[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
