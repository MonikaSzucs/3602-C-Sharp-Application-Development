using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class StringUtilities
    {
        public static string ToProper(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                char[] temp = input.ToLower().ToCharArray();
                int length = temp.Length;
                string chars = @" .'\";

                temp[0] = char.ToUpper(temp[0]);


                for (int counter = 1; counter < length; counter++)
                {
                    if (chars.Contains(temp[counter - 1]))
                    {
                        temp[counter] = char.ToUpper(temp[counter]);
                    }
                }

                return new string(temp);
            }
            else
            {
                return input;
            }
        }
    }
}
