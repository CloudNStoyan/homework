using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ExtensionStringBuild
    {
        public static StringBuilder Substring(this StringBuilder builder,int index,int length)
        {
            string text = builder.ToString();
            text = text.Substring(index, length);

            return new StringBuilder(text);

            
        }
    }
}
