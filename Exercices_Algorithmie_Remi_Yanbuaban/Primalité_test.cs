using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice
{
    class Primalité_test
    {
        public Primalité_test()
        {
            Console.Clear();
            Console.WriteLine("Entrez le nombre à tester :");
            int n1 = Int32.Parse(Console.ReadLine());
            var is_true = algo_2(n1);
            if (is_true == true)
                Console.WriteLine("Le nombre choisi " + n1 + " est un nombre premier");
            else
                Console.WriteLine("Le nombre choisi " + n1 + " n'est pas un nombre premier");
            calcul_time(n1);
        }

        private bool algo_1(int numTest)
        {
            var isfirst = true;
            for(var i = 3; i <= numTest-1; i++)
            {
                if(numTest % i == 0)
                {
                    isfirst = false;
                }
            }
            return isfirst;
        }

        private bool algo_2(int numTest)
        {
            var isfirst = true;
            for (var i = 3; i <= Math.Sqrt(numTest); i++)
            {
                if (numTest % i == 0)
                {
                    isfirst = false;
                }
            }
            return isfirst;
        }

        private void calcul_time(int numTest)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            algo_1(numTest);
            watch.Stop();
            Console.WriteLine("Le temps d'exécution de l'algo 1 est de " + watch.ElapsedMilliseconds*0.001 + " s");
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            algo_2(numTest);
            watch2.Stop();
            Console.WriteLine("Le temps d'exécution de l'algo 2 est de " + watch2.ElapsedMilliseconds*0.001 + " s");
        }
    }
}
