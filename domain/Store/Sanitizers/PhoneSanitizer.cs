using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Sanitizers
{
    internal class PhoneSanitizer
    {
        public static string Sanitize(string str)
        {
            str = string.Concat("8", str.Replace(" ", "").Replace("-", "").Replace("+", "").AsSpan(1));
            return str;
        }
    }
}
