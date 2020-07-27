using System;
using System.Diagnostics.Tracing;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int NPowerInitial = int.Parse(Console.ReadLine());
            int NPower = NPowerInitial;
            int MDistance = int.Parse(Console.ReadLine());
            int YFactor = int.Parse(Console.ReadLine());
            int count = 0;

            while (NPower >= MDistance)
            {
                NPower -= MDistance;
                count++;
                if (NPower * 1.0 / NPowerInitial == 0.50)
                {
                    if (YFactor != 0)
                    {
                        NPower /= YFactor;
                    }
                }
            }
            Console.WriteLine(NPower);
            Console.WriteLine(count);

        }
    }
}
