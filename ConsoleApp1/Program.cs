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
            int[] mass = { 1, 1, 1, 1, 2, 3, 2 };
            for (int i = 0; i < mass.Length; i++)
            {
                int summLeft = 0;
                int summRigh = 0;
                //Summ of left sight 
                for (int j = 0; j < i; j++)
                {
                    summLeft += mass[j];
                }
                //Summ of right sight 
                for (int j = i + 1; j < mass.Length; j++)
                {
                    summRigh += mass[j];
                }

                if (summLeft == summRigh)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (summLeft != summRigh && i == mass.Length - 1)
                {
                    Console.WriteLine("None index match");
                    Console.ReadLine();
                    return;
                }
            }
            Console.ReadLine();
        }