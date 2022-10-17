using System;

namespace Common.Extentions
{
    public static class StringExtentions
    {
        public static int GetWordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
