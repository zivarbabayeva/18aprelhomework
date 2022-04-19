using System;
using System.Collections.Generic;
using System.Text;

namespace Homework18aprel.Models
{
    static class Extension
    {
        public static bool CheckChar(this string CompanyName, char symbol, char letter)
        {
            return CompanyName.Contains(symbol);
        }
    }
   
   
}
