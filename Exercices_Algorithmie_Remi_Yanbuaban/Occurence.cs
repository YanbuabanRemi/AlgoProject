using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice
{
    class Occurence
    {
        public Occurence()
        {
            Console.Clear();
            int[] tableau = new int[] { 0, 0, 1, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6, 9, 8, 8, 5, 12, 0, 7 };
            checkOccurence(tableau);
        }

        private void checkOccurence(int [] tab)
        {
            var maxInt = tab.Max();
            int[] tableau2 = new int[maxInt+1];
            for(var i = 0; i <= tab.Length-1; i++)
            {    
                var nombreOccurence = 0;
                for(var j = 0; j <= tab.Length-1; j++)
                {
                    if (tab[i] == tab[j])
                    {
                        nombreOccurence++;
                    }
                }
                tableau2[i] = nombreOccurence;
            }
            
            for(var i = 0; i <= tableau2.Length-1; i++)
            {
                if (tableau2[i] != 0)
                {
                    Console.WriteLine("Le nombre " + Array.IndexOf(tableau2, tableau2[i]) + " apparait " + tableau2[i] + " fois");
                }
            }
        }
    }
}
