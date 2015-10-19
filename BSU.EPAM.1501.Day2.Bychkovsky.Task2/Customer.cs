using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSU.ASP1501.Day2.Bychkovsky.Task2
{
    public class Customer : IFormattable
    {
        public string Name { get; set; }

        public string ContactPhone { get; set; }

        public decimal Revenue { get; set; }

        public Customer(string name, string contactPhone, decimal rev)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = rev;
        }

        /// <summary>
        /// String representation of the object Customer.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format(CultureInfo.CurrentCulture, "Customer name: {0}\nContact phone: {1}\nRevenue: {2:C}", Name, ContactPhone, Revenue);
        }

        /// <summary>
        /// String representation of the object Customer with user's IFormatProvider
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
        {
            return String.Format(provider, "Customer name: {0}\nContact phone: {1}\nRevenue: {2:C}", Name, ContactPhone, Revenue);
        }

        /// <summary>
        /// String representation the part of data of the object Customer.
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public string ToString(string Format)
        {
            if (string.IsNullOrEmpty(Format))
                return ToString();
            switch (Format.ToUpperInvariant())
            {
                case "NP": return String.Format(CultureInfo.CurrentCulture, "Customer name: {0}\nContact phone: {1}", Name, ContactPhone);
                case "NR": return String.Format(CultureInfo.CurrentCulture, "Customer name: {0}\nRevenue: {1:C}", Name, Revenue);
                case "PR": return String.Format(CultureInfo.CurrentCulture, "Contact phone: {0}\nRevenue: {1:C}", ContactPhone, Revenue);
                case "N": return String.Format(CultureInfo.CurrentCulture, "Customer name: {0}", Name);
                case "P": return String.Format(CultureInfo.CurrentCulture, "Contact phone: {0}", ContactPhone);
                case "R": return String.Format(CultureInfo.CurrentCulture, "Revenue: {0:C}", Revenue);
                default: throw new Exception("Wrong format!");
            }
        }

        /// <summary>
        /// String representation the part of data of the object Customer with user's IFormatProvider
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public string ToString(string Format, IFormatProvider provider)
        {
            if (string.IsNullOrEmpty(Format))
                return ToString();
            if (provider == null) 
                provider = CultureInfo.CurrentCulture;
            switch (Format.ToUpperInvariant())
            {
                case "NP": return String.Format(provider, "Customer name {0}\nContact phone {1}", Name, ContactPhone);
                case "NR": return String.Format(provider, "Customer name {0}\nRevenue {1:C}", Name, Revenue);
                case "PR": return String.Format(provider, "Contact phone {0}\nRevenue {1:C}", ContactPhone, Revenue);
                case "N": return String.Format(provider, "Customer name {0}", Name);
                case "P": return String.Format(provider, "Contact phone {0}",ContactPhone);
                case "R": return String.Format(provider, "Revenue {0:C}",Revenue);
                default: throw new Exception("Wrong format!");
            }
        }
    }
}
