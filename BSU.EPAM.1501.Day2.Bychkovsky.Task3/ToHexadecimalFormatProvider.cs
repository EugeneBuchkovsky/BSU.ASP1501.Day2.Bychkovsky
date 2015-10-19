using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSU.ASP1501.Day2.Bychkovsky.Task3
{
    /// <summary>
    /// Class for representation integer in hexadecimal.
    /// </summary>
    public class ToHexadecimalFormatProvider : IFormatProvider, ICustomFormatter
    {
            static readonly string Hnumbers = "0123456789ABCDEF";

            IFormatProvider _parent;   // Allows consumers to chain format providers

            public ToHexadecimalFormatProvider() : this(CultureInfo.CurrentCulture) { }

            public ToHexadecimalFormatProvider(IFormatProvider parent)
            {
                _parent = parent;
            }

            public object GetFormat(Type formatType)
            {
                if (formatType == typeof(ICustomFormatter)) return this;
                return null;
            }

            public string Format(string format, object arg, IFormatProvider prov)
            {
                if ((arg == null))
                    throw new ArgumentNullException();

                if (format != "H" || (arg.GetType() != typeof(int)))
                    return string.Format(_parent, "{0:" + format + "}", arg);

                StringBuilder result = new StringBuilder();
                string digitList = string.Format(CultureInfo.InvariantCulture, "{0}", arg);

                int res = (int)arg, residue;
                while (res != 0)
                {
                    residue = res % 16;
                    result.Append(Hnumbers[residue]);
                    res /= 16;
                }

                char[] reverseResult = result.ToString().ToCharArray();
                Array.Reverse(reverseResult);
                return new string(reverseResult);
            }
        
    }
}
