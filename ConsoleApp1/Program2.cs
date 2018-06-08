using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxMass = 0;
            int[] mass = { 5, 1, 4, 10, 15, 14, 2, 1 };
            Max(mass, ref maxMass, 0);
            Console.WriteLine(maxMass);
            Console.ReadLine();
        }
        static void Max(int[] _mass, ref int max, int massIndex)
        {
            if (massIndex == _mass.Length) { return; }
            if (max < _mass[massIndex])
            {
                max = _mass[massIndex];
                //massIndex += 1; 
                //Max(_mass, ref max, massIndex); 
            }
            massIndex = (massIndex < _mass.Length) ? massIndex + 1 : massIndex;
            Max(_mass, ref max, massIndex);
        }