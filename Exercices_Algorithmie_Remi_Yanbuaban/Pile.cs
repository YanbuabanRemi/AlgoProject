using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice
{
    class Pile
    {
        public Pile()
        {
            Console.Clear();
            Console.WriteLine("Quel fonction à tester ?");
            Console.WriteLine("1 : is_stack_empty");
            Console.WriteLine("2 : push_stack");
            Console.WriteLine("3 : pop_stack");
            Console.WriteLine("4 : postfixée");
            int choice = Int32.Parse(Console.ReadLine());
            int[] tab = new int[] { 1, 5, 6, 87, 12, 64, 2, 8, 3 };
            string[] tabPostFixee = new string[] { "7", "8", "2", "-", "2", "/", "1", "+", "*"};
            string[] tabPostFixee2 = new string[] { "7", "8", "2", "-", "2", "/", "1", "+", "*", "7", "+", "3", "*","4","-" };
            string[] tabPostFixee3 = new string[] { "10", "3", "4", "*","16","4","-","/","+" };
            switch (choice)
            {
                case 1:
                    showTab(tab);
                    var istrue = is_stack_empty(tab);
                    Console.WriteLine(istrue);
                    break;
                case 2:
                    showTab(tab);
                    Console.WriteLine("Quel numero à ajouter");
                    int num = Int32.Parse(Console.ReadLine());
                    int[] newtab = push_stack(tab, num);
                    showTab(newtab);
                    break;
                case 3:
                    showTab(tab);
                    Console.WriteLine("Le dernier élèment de la pile est :" + pop_stack(tab) );
                    break;
                case 4:
                    foreach(var item in tabPostFixee2)
                        Console.Write(item + " ");
                    Console.WriteLine("Le résultat est : " + postfixee(tabPostFixee3));
                    break;
            }
        }

        private void showTab(int[] tab)
        {
            foreach(var item in tab)
            {
                Console.Write(item + " ");
            }
        }

        private bool is_stack_empty(int[] tab)
        {
            if (tab.Length != 0)
                return false;
            return true;
        }

        private int[] push_stack(int[] tab, int element)
        {
            int[] newTab = new int[tab.Length +1];
            for(var i = 0; i <= tab.Length-1; i++)
            {
                newTab[i] = tab[i];
            }
            newTab[tab.Length] = element;
            return newTab;
        }

        private int pop_stack(int[] tab)
        {
            return tab[tab.Length-1];
        }

        private bool int_or_not(string test)
        {
            try
            {
                Int32.Parse(test);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private int postfixee(string[] tab)
        {
            Stack<int> pile = new Stack<int>();
            foreach(var item in tab)
            {
                if(int_or_not(item))
                {
                    pile.Push(Int32.Parse(item));
                }
                else
                {
                    var itemRight = pile.Pop();
                    var itemLeft = pile.Pop();
                    switch (item)
                    {
                        case "+":
                            pile.Push(itemLeft + itemRight);
                            break;
                        case "-":
                            pile.Push(itemLeft - itemRight);
                            break;
                        case "*":
                            pile.Push(itemLeft * itemRight);
                            break;
                        case "/":
                            pile.Push(itemLeft / itemRight);
                            break;
                    }
                }
            }
            return pile.Pop();
        }
    }
}
