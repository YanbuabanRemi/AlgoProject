using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Exercice
{
    class Recursivite
    {
        public Recursivite()
        {
            Console.Clear();
            Console.WriteLine("Quel fonction tester :");
            Console.WriteLine("1 : display_numbers ");
            Console.WriteLine("2 : extractPartNumber ");
            Console.WriteLine("3 : isPalindrome ");
            Console.WriteLine("4 : gcd ");
            Console.WriteLine("5 : ackermann ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Quel nombre à tester :");
                    int choice1 = Int32.Parse(Console.ReadLine());
                    display_numbers(choice1);
                    break;
                case 2:
                    Console.WriteLine("Quel nombre à tester :");
                    int choice2 = Int32.Parse(Console.ReadLine());
                    extractPartNumber(choice2);
                    break;
                case 3:
                    Console.WriteLine("Quel phrase a tester :");
                    string text = Console.ReadLine();
                    if(isPalindrome(text))
                        Console.WriteLine("La phrase est un palindrome ");
                    else
                        Console.WriteLine("Cette phrase n'est pas palindrome ");
                    break;
                case 4:
                    Console.WriteLine("Nombre 1");
                    int choicegcd = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nombre 2");
                    int choicegcd2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Le gcd est de :" + gcd(choicegcd, choicegcd2));
                    break;
                case 5:
                    Console.WriteLine("Quel est le premier nombre à tester :");
                    int choice10 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Quel est le deuxième nombre à tester :");
                    int choice20 = Int32.Parse(Console.ReadLine());
                    int result = ackermann(choice10, choice20);
                    Console.WriteLine("A(" + choice10 + "," + choice20 + ") = " + result);
                    break;
            }
        }

        private void display_numbers(int n)
        {
            if(n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                display_numbers(n - 1);
                Console.WriteLine(n);  
            }
        }

        private void extractPartNumber(int n)
        {

            var i = 0;
            if(n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                extractPartNumber(n % 10);
                Console.WriteLine(i);
            }
        }

        private bool isPalindrome(string text)
        {
            text = text.Trim();
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return isPalindrome(text.Substring(1, text.Length - 2));
            }
        }

        private int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }

        private int ackermann(int a, int b)
        {
            if (a == 0)
                return b+1;
            else
            {
                if (b == 0)
                    return ackermann(a-1, 1);
                else
                    return ackermann(a-1, ackermann(a, b-1));
            }
        }

    }
}
