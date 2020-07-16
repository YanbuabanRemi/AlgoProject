using activite_1;
using Exercice;
using System;
using System.Dynamic;
using System.Xml.Schema;

namespace Exercices_Algorithmie_Remi_Yanbuaban
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Choisir l'exercice à tester : ");
                Console.WriteLine("404 : Quitter");
                Console.WriteLine("0 : Effacer la console");
                Console.WriteLine("1 : Activite 1");
                Console.WriteLine("2 : Activité 2 : Primalité");
                Console.WriteLine("3 : Activité 3 : Occurence");
                Console.WriteLine("4 : Activité 4 : Tri");
                Console.WriteLine("5 : Activité 5 : Recursivité");
                Console.WriteLine("6 : Activité 6 : Les piles");
                Console.WriteLine("");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        new Activite_1();
                        break;
                    case 2:
                        new Primalité_test();
                        break;
                    case 3:
                        new Occurence();
                        break;
                    case 4:
                        new Tri();
                        break;
                    case 5:
                        new Recursivite();
                        break;
                    case 6:
                        new Pile();
                        break;
                    case 404:
                        Console.WriteLine("Fin");
                        break;
                    default:
                        Console.WriteLine("Erreur d'entrée ");
                        break;
                }
            } while (choice != 404);
        }
    }
}
