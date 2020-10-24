using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] pleb = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                pleb[i] = str[i];
            }
            Array.Sort(pleb);
            string bruh = string.Join("", pleb);
            return bruh;



        }



    }
}
