using System;

namespace PRNG
{
    static class Program
    {
        static int Main()
        {
            //string Seed = "Test Seed";
            int Seed = int.MaxValue;
            int maxValue = 128;
            PRandom ram = new PRandom(Seed, maxValue);

            bool running = true;

            while (running)
            {
                Console.WriteLine(ram.Next());
                //Console.WriteLine((ram.Next() % 4) + 5); <= testing some modulos
            }
            return 0;
        }
    }
}
