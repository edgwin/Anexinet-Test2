using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public static class IntegerExtension
    {
        public static bool IsDivisor(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
