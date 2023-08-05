//Credits to bluecelcius in https://stackoverflow.com/questions/27778615/pseudo-random-number-generator-c-sharp
using System;
using System.Collections.Generic;

namespace PRNG
{
    public class PRandom
    {
        int currentIndex = 0;
        List<int> num = new();
        public PRandom() { }
        public PRandom(string seed, int range)
        {
            currentIndex = 0;
            GenerateList(seed, 0, range);
        }
        public void GenerateList(string seed, int minimum, int range)
        {
            int tbSeed = seed.GetHashCode();
            int min = minimum;
            int max = range;
            int number;
            string display = "";

            Random rand = new(tbSeed);

            num = new();

            for (int i = min; i < max; i++)
            {
                number = rand.Next(min, max);
                if (num.Contains(number))
                {
                    while (true)
                    {
                        number = rand.Next(min, max);
                        if (num.Contains(number))
                        {
                            // if exist do nothing and then random again while true  
                        }
                        else
                        {
                            num.Add(number);
                            break;
                        }

                    }
                }
                else
                {
                    num.Add(number);
                }

                display += "" + number + " ";

            }

            Console.WriteLine("Your numbers: " + display + "\n");
        }
        public int Next()
        {
            int value = num[currentIndex];
            currentIndex++;
            if (currentIndex >= num.Count) currentIndex = 0;
            return value;
        }
    }
}
