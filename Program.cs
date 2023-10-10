using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmenyPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mojePole = { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };
            mojePole.VypisPole();
            Console.WriteLine();
            mojePole.UpravPole();
            mojePole.VypisPole();
            Console.WriteLine();
            Console.WriteLine("Největší číslo: " + mojePole.maxCislo());
            Console.WriteLine();
            VypisPole(mojePole.SetridVzestupne());
            Console.ReadLine();
        }
        public static void VypisPole(int[] pole)
        {
            foreach (int i in pole) Console.Write(i + ", ");
            Console.WriteLine();
        }
}
}
