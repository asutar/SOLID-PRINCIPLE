using SOLID_PRINCIPLE.L;
using SOLID_PRINCIPLE.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apple objApple = new Orange();
            //objApple.GetColor();
            //Console.WriteLine(objApple.GetColor());
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
            Console.ReadLine();



        }
    }
}
