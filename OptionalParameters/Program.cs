using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimango KSI
namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(3);
            VisitPlanets(4);
            VisitPlanets(5);
            VisitPlanets();
        }// Method without the optional parameter

        static void VisitPlanets(int numberOfPlanets = 0)//for string (string name=".")     // method with the optional parameter
        {
            Console.WriteLine($"You visited {numberOfPlanets}  new planets...");
        }
    }
}