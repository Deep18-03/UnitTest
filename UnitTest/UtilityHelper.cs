using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UnitTest
{
    public static class UtilityHelper
    {
        public static string convertString(this string inputstring)
        {

            if (inputstring.Length > 0)
            {

                char[] charArray = inputstring.ToCharArray();

                for (var i = 0; i < inputstring.Length; i++)
                    charArray[i] = char.IsUpper(charArray[i]) ? char.ToLower(charArray[i]) : char.ToUpper(charArray[i]);
                return new string(charArray);

            }
            return inputstring;

        }

        public static string Capitalized(string inputstring)
        {
            if (inputstring.Length > 0)
            {
                char[] charArray = inputstring.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return inputstring;

        }

        public static string RemoveLastChar(this string inputstring)
        {
            if (inputstring.Length > 0)
            {
                string inputstringminus1 = inputstring.Remove(inputstring.Length - 1, 1);
                return inputstringminus1;
            }
            return inputstring;

        }

        public static int WordCount(this string inputstring)
        {
            int Count = 0;
            for (int i = 0; i < inputstring.Length - 1; i++)
            {
                //Counts all the spaces present in the string  
                //It doesn't include the first space as it won't be considered as a word  
                if (inputstring[i] == ' ' && Char.IsLetter(inputstring[i + 1]) && (i > 0))
                {
                    Count++;
                }
            }
            Count++;
            return Count;
        }

        public static bool AllCharlower(this string inputstring)
        {
            bool result=false;
            char[] charArray = inputstring.ToCharArray();
            for (int i = 0; i < inputstring.Length; i++)
            {

                if (char.IsLower(charArray[i]))
                {
                    result=true;
                   
                }
                else
                {
                    result = false;
                    break;
                }

            }
            return result;
        }

        public static bool AllChaUpper(this string inputstring)
        {
            bool result = false;
            char[] charArray = inputstring.ToCharArray();
            for (int i = 0; i < inputstring.Length; i++)
            {

                if (char.IsUpper(charArray[i]))
                {
                    result = true;

                }
                else
                {
                    result = false;
                    break;
                }

            }
            return result;
        }


        public static bool isNumber(this string inputstring)
        {
            for (int i = 0; i < inputstring.Length; i++)
                if (char.IsDigit(inputstring[i]) == false)
                    return false;

            return true;
          
        }

        public static int StrToINT(this string inputstring)
        {
           
            int x = Int32.Parse(inputstring);
            return x;

        }
        public static string TitleCase(this string inputstring)
        {
            char[] charArray = inputstring.ToCharArray();
            return char.ToUpper(charArray[0]) + inputstring.Substring(1).ToLower();

        }


    }
}
