using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles
{
    public class FirstToUpper
    {
        public static string ToUpper(string pWord)
        {
            string word = "";
            string WORD = pWord.ToUpper();

            for (int i = 0; i < pWord.Length; i++)
            {
                if (i == 0)
                {
                    word += WORD[i].ToString();
                }

                else
                {
                    word += pWord[i].ToString();
                }
            }

            return word;
        }
    }
}
