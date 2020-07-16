using System;
using System.Collections.Generic;
using System.Text;

namespace activite_1
{
    class Activite_1
    {
        public Activite_1()
        {
            Console.Clear();
            Console.WriteLine("Quel activité ?");
            Console.WriteLine("1 : Activité 1");
            Console.WriteLine("2 : Compare opération");
            int choix = Int32.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Quel est le nombre de table ? ");
                    int n1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Quel est la longueur de la table ? ");
                    int n2 = Int32.Parse(Console.ReadLine());
                    multiplication_tables(n1, n2);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Entrer la borne inférieur :");
                    int arg1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Entrer la borne supérieur :");
                    int arg2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Entrer le nombre d'éléments ");
                    int arg3 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Entrer le nombre de réduction :");
                    int arg4 = Int32.Parse(Console.ReadLine());
                    Compare_operation(arg1, arg2, arg3, arg4);
                    break;
            }

            
        }

        private void multiplication_tables(int limite_i, int limite_j)
        {

            Console.WriteLine("Table de multiplication : " + limite_i + " x " + limite_j);
            var n = 1;
            for (var i = 1; i <= limite_i; i++)
            {
                Console.Write("Table of     " + i + " =>");
                for (var j = 1; j <= limite_j; j++)
                {
                    Console.Write("   " + n);
                    n += i;
                }
                Console.WriteLine("");
                n = i + 1;
            }
        }

        private int Addition(int arg_1, int arg_2, int arg_3, int arg_4)
        {
            Random randomNumber = new Random();
            var z = 0;
            for (var i = 1; i <= arg_4; i++)
            {
                for (var j = 1; j <= arg_3; j++)
                {
                    z += randomNumber.Next(arg_1, arg_2);
                }
            }
            return z;
        }

        private int Multiplication(int arg_1, int arg_2, int arg_3, int arg_4)
        {
            Random randomNumber = new Random();
            var z = 1;
            for (var i = 1; i <= arg_4; i++)
            {
                for (var j = 1; j <= arg_3; j++)
                {
                    z = z * randomNumber.Next(arg_1, arg_2);
                }
            }
            return z;
        }

        private void Compare_operation(int arg_1, int arg_2, int arg_3, int arg_4)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Addition(arg_1, arg_2, arg_3, arg_4);
            watch.Stop();
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Multiplication(arg_1, arg_2, arg_3, arg_4);
            watch2.Stop();
            Console.WriteLine("Le temps d'exécution de l'algo d'addition est de " + watch.ElapsedMilliseconds * 0.001 + " s");
            Console.WriteLine("Le temps d'exécution de l'algo de multiplication est de " + watch2.ElapsedMilliseconds * 0.001 + " s");
        }
    }
}
