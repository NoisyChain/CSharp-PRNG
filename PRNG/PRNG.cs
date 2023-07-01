//Credits to bluecelcius in https://stackoverflow.com/questions/27778615/pseudo-random-number-generator-c-sharp
using System;
using System.Collections.Generic;

public static class PRNG
{
    public static int GetNumber(string seed, int minimum, int range, int index)
    {
        int tbSeed = seed.GetHashCode();
        int min = minimum;
        int max = range;
        int number;
        string display = "";
        
        Random rand = new(tbSeed);
        List<int> num = new();


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

        Console.WriteLine(display);
        //For Unity
        //UnityEngine.Debug.Log(display);

        int value = num[index];
        return value;
    }
}
