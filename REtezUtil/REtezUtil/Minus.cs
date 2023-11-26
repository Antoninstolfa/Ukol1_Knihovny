using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REtezUtil
{
    public class Minus
    {
        /// <summary>
        /// Odečte znak ze stringu
        /// </summary>
        string vstup;
        public Minus(string vstup)
        {
            this.vstup = vstup;
        }

        static public string operator -(Minus x, Minus y)
        {
            return x.vstup.Replace(y.vstup, "");
        }
    }
}
