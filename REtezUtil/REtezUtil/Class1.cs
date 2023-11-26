using System;

namespace REtezUtil
{
    public class Class1
    {
        /// <summary>
        /// Smaže číslice ve    řetězci
        /// </summary>
        /// <param name="vstup">Řetězec string</param>
        static public string Smaz(string vstup)
        {
            foreach (char znak in vstup)
            {
                if (znak >= '0' && znak <= '9')
                {
                    vstup = vstup.Replace(znak, ' ');
                }
            }
            return vstup;
        }


        /// <summary>
        /// Vypíše Upracený řetězec
        /// </summary>
        /// <param name="vstup">Upravený Řetězec</param>
        /// <returns>Vrací Upravený řetězec </returns>
        static public string Zobraz(string vstup)
        {
            return vstup;
        }
    }
}

