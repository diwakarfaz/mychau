using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Utility
{
    public class BLLUtility
    {
        public static string GetIDByLetters(string name, int IDlength, int numberOfLetters)
        {
            char[] chars = name.ToCharArray();
            string result = "";
            int j = 0;
            foreach (var c in chars)
            {
                if (result.Length < IDlength)
                {
                    if (j < numberOfLetters)
                    {
                        if (Char.ToUpper(c) != ' ') result = result + Char.ToUpper(c);
                        j++;
                    }
                    else
                    {
                        if (c == ' ') j = 0;
                    }
                }
            }

            return result;
        }

        public static string GetIDBy3Letters(string name, int length)
        {
            return GetIDByLetters(name, length, 3);
        }
    }
}
