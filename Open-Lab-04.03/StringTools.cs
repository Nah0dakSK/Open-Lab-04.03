using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string str)
        {
           str = "hello";
           str = str.Substring(1, str.Length - 2);
            return str;
        }
    }
}
