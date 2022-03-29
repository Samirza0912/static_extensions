using System;
using System.Text;

namespace at_lesson.Helper
{
    static class Extension
    {
        public static StringBuilder Reverse(this string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result.Append(str[i]);
            }
            return result;
        }
        public static int Pow(this int num, int num2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            {
                result *= num;
            }
            return result; 
        }
        public static bool IsUpper(this string word)
        {
            bool result = false;
            for (int i = 0; i < word.Length; i++)
            {
                result = char.IsUpper(word[i]);
                if (result==true)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
