using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice
{
    class Tri
    {
        public Tri()
        {
            Console.Clear();
            Console.WriteLine("Valeur minimum :");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Valeur maximum :");
            int max = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nombre de valeur du tableau :");
            int nbvaleur = Int32.Parse(Console.ReadLine());
            int[] tab = creerTableau(min, max, nbvaleur);
            triABulle(tab);
        } 

        private void triABulle(int [] tab)
        {
            afficherTableau(tab);
            for(var i = tab.Length-2; i >=0; i--)
            {
                for(var j = 0; j <= i; j++)
                {
                    if(tab[j+1] < tab[j])
                    {
                        int value = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = value;
                    }
                }
            }
            afficherTableau(tab);
        }

        private void triRapide(int [] tab, int gauche, int droite)
        {

        }
        private int calculPivot(int[] tab, int gauche, int droite)
        {

            return 2;
        }

        private void calculTempsTri(int [] tab)
        {

        }

        private void afficherTableau(int[] tab)
        {
            foreach(var item in tab)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("");
        }

        private int[] creerTableau(int min, int max, int nbvaleur)
        {
            int[] tab = new int[nbvaleur];
            Random randomNumber = new Random();
            for(var i = 0; i < nbvaleur; i++)
            {
                tab[i] = randomNumber.Next(min, max);
            }
            return tab;
        }
    }
}
