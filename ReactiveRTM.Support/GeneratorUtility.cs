using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Support
{
    public static class GeneratorUtility
    {
        public static string SnakeCaseToCamelCase(string snake)
        {
            bool nextIsLarge = true;
            string camel = "";

            foreach (var c in snake)
            {
                if (c == '_')
                {
                    nextIsLarge = true;
                    continue;
                }
                if (nextIsLarge)
                {
                    camel += c.ToString().ToUpper();
                    nextIsLarge = false;
                }
                else
                {
                    camel += c;
                }
            }
            return camel;
        }
    }
}
