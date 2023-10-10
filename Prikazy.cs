using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZmenyPole
{
    static public class Prikazy
    {
        public static int[] UpravPole(this int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < 0) pole[i] = Math.Abs(pole[i]); 
                else { if (pole[i] == 0) pole[i] = i; }
            }
            Console.WriteLine("Hodnoty v poli byly upraveny.");
            return (pole);
        }
        public static void VypisPole(this int[] pole)
        {
            foreach (int i in pole) Console.Write(i + ", ");
            Console.WriteLine();
        }

        public static int maxCislo(this int[] pole)
        {
            int maxCislo = pole[0];
            foreach (int k in pole)
            {
                if (k > maxCislo) maxCislo = k;
            }
            return maxCislo;
        }
        public static int[] SetridVzestupne(this int[] pole)
        {
            int maxCislo = pole.maxCislo();
            int[] novePole = new int[pole.Length];
            int index = 0;

            for (int k = 0; k < novePole.Length; k++)
            {
                int minimalni = pole[0];

                for (int i = 0; i < pole.Length; i++)
                {
                    if (pole[i] <= minimalni)
                    {
                        minimalni = pole[i];
                        index = i;
                    }
                }
                pole[index] = maxCislo+1;
                novePole[k] = minimalni;
            }

            Console.WriteLine("Setřídění bylo dokončeno.");
            return novePole;
        }
    }
}

