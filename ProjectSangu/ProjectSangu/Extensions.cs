using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSangu
{
    public static class Extensions
    {
        public static bool IsGeorgianLetter(this char value)
        {
            return value >= 'ა' && value <= 'ჵ';
        }
    }
}
