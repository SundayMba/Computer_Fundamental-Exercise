using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Solutions
{
    internal class ReverseWord
    {
        public static string ReverseWords(string str)
        {
            //Write your code here
            int len = str.Length;
            string revWord = "";
            string mainStr = "";

            for (int i = 0; i < len; i++)
            {
                if (str[i] == ' ')
                {
                    revWord += ' ';
                    mainStr += revWord;
                    revWord = "";
                }
                else
                {
                    revWord = str[i] + revWord;
                }
                if (i == len - 1)
                {
                    if (str[i] != ' ')
                    {
                        mainStr += revWord;
                    }
                }
            }
            return mainStr;
        }
    }
}
