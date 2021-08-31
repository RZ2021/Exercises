using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Work
    {
        public void sumNums()
        {
            string cont = "1";
            while (cont == "1")
            {
                Console.WriteLine("Welcome to the number game. Press 1 to continue or any other key to escape.");
                cont = Console.ReadLine();
                if (cont != "1")
                {
                    break;
                }

                Console.WriteLine("Enter in a number");
                int numA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter in a second number");
                int numB = Convert.ToInt32(Console.ReadLine());
                int sum = numA + numB;
                if (numA == numB)
                {
                    sum *= 3;
                    Console.WriteLine(sum.ToString());
                }
                else
                {
                    Console.WriteLine(sum.ToString());
                }
            }
        }

        public void absDiff()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Find the absolute difference between 51 and any number. Continue yes or no");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("Enter in a number");
                int num = Convert.ToInt32(Console.ReadLine());
                int diff = Math.Abs(51 - num);

                if (num > 51)
                {
                    Console.WriteLine((diff * 3).ToString());
                }
                else
                {
                    Console.WriteLine(diff.ToString());
                }
            }
        }

        public void thirty()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Thirty finder. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("\nEnter in a number");
                int numA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter in a second number");
                int numB = Convert.ToInt32(Console.ReadLine());

                int sum = numA + numB;
                if (sum == 30 || numA == 30 || numB == 30)
                {
                    Console.WriteLine("\nTrue\n");
                }
                else
                {
                    Console.WriteLine("\nFalse\n");
                }

            }
        }

        public void withinHun()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Within a hundred finder. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("\nEnter in a number");
                int numA = Convert.ToInt32(Console.ReadLine());

                if ((numA < 111 && numA > 89) || (numA < 211 && numA > 189))
                {
                    Console.WriteLine("\nTrue\n");
                }
                else
                {
                    Console.WriteLine("\nFalse\n");
                }

            }
        }

        public void addStr()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Add if to string. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }
                Console.WriteLine("Enter in a sentence: \n");
                string usStr = Console.ReadLine();

                if (usStr.Substring(0, 2) == "if")
                {
                    Console.WriteLine("\n" + usStr + "\n");
                }
                else
                {
                    Console.WriteLine("if" + usStr);
                }
            }

        }

        public void oneWord()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Take one letter away. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("\nWrite a word:");
                string word = Console.ReadLine();
                Console.WriteLine("Enter a number 0 - " + (word.Length - 1).ToString());
                int num = Convert.ToInt32(Console.ReadLine());

                word = word.Remove(num, 1);
                Console.WriteLine("\n" + word.ToString());
            }
        }

        public void firstLast()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Letter swaps. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("Enter in a word:");
                string firstStr = Console.ReadLine();

                int end = firstStr.Length - 1;
                string a = firstStr.Substring(0,1);
                string b = firstStr.Substring(firstStr.Length - 1);
                
                firstStr = b + firstStr.Remove(0,1);
                firstStr = firstStr.Remove(end, 1) + a;

                Console.WriteLine("\n" + firstStr);
            }
        }

        public void twoLetters()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Letter swaps. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("\nEnter a string: ");
                string s = Console.ReadLine();

                if(s.Length < 2)
                {
                    Console.WriteLine(s + "\n");
                }
                else
                {
                    string newS = s.Substring(0, 2);
                    Console.WriteLine("\n" + newS + newS + newS + newS + "\n");
                }
            }
        }

        public void frontBack()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("front back. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("\nEnter a string: ");
                string s = Console.ReadLine();

                string n = s.Substring(s.Length - 1);

                Console.WriteLine(n + s + n);
            }
        }

        public void multiOf()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Multiples of seven and three. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("Enter in a number: ");
                int num = Convert.ToInt32(Console.ReadLine());


                if(num % 3 == 0 || num % 7 == 0)
                {
                    Console.WriteLine("\nTrue\n");
                }
                else
                {
                    Console.WriteLine("\nFalse\n");
                }

            }
        }

        public void threeLetters()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Three letters. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("\nEnter a string: ");
                string s = Console.ReadLine();

                if(s.Length >= 3)
                {
                    string n = s.Substring(0, 3);
                    Console.WriteLine("\n" + n + s + n + "\n");
                }
                else
                {
                    string n = s.Substring(0);
                    Console.WriteLine("\n" + n + s + n + "\n");
                }

            }
        }

        public void cSharp()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Three letters. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no")
                {
                    break;
                }

                Console.WriteLine("\nEnter a string: ");
                string s = Console.ReadLine();
                string c = s.Substring(0, 2);

                if(c == "C#")
                {
                    Console.WriteLine("\nTrue\n");
                }
                else
                {
                    Console.WriteLine("\nFalse\n");
                }
            }
        }

        public void temps()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Temps. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no" || yn == "n")
                {
                    break;
                }

                Console.WriteLine("\nEnter a temp: ");
                int tempOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter another temp: ");
                int tempTwo = Convert.ToInt32(Console.ReadLine());

                if (tempOne < 0 && tempTwo > 100)
                {
                    Console.WriteLine("\nTrue\n");
                }
                else
                {
                    Console.WriteLine("\nFalse\n");
                }
            }
        }

        public void ranges()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Ranges. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no" || yn == "n")
                {
                    break;
                }

                Console.WriteLine("\nEnter a number: ");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter another num: ");
                int numTwo = Convert.ToInt32(Console.ReadLine());

                if ((numOne >= 100 && numOne <= 200) || (numTwo >= 100 && numTwo <= 200))
                {
                    Console.WriteLine("\nTrue\n");
                }
                else
                {
                    Console.WriteLine("\nFalse\n");
                }
            }
        }

        public void rangeThree()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Ranges three. Continue yes or no:");
                string yn = Console.ReadLine();
                if (yn == "No" || yn == "no" || yn == "n")
                {
                    break;
                }

                Console.WriteLine("\nEnter a number: ");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter another number: ");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter another number: ");
                int numThree = Convert.ToInt32(Console.ReadLine());

                if ((numOne >= 20 && numOne <= 50) || (numTwo >= 20 && numTwo <= 50) || (numThree >= 20 && numThree <= 50))
                {
                    Console.WriteLine("\nTrue\n");
                }
                else
                {
                    Console.WriteLine("\nFalse\n");
                }
            }
        }
    }
}
