using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EKIFKUF
{
    class Tools
    {
        public static string csvGenerator(IEnumerable<string> kolekcija)
        {
            var res = new StringBuilder();

            foreach (string x in kolekcija)
            {
                res.Append(x);
                res.Append(";");
            }

            string rezultat = res.ToString();

            return rezultat.Remove(rezultat.Length - 1);
        }

        public static string decimalFixer(object input)
        {
            double value = 0.0;

            try
            {
                if (input != null)
                    value = Double.Parse(input.ToString());
            }
            catch { }

            return String.Format("{0:0.00}", value);
        }
    }
}
