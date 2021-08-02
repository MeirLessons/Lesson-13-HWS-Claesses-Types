using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_HWS_Interfaces_And_Claesses_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car
            {
                Model = "Car1",
                NumberOfWeels = 4,
                NumOfDoors = 3
            };
            Car c2 = new Car
            {
                Model = "Car2",
                NumberOfWeels = 6,
                NumOfDoors = 2
            };
            Car c3 = new Car
            {
                Model = "Car3",
                NumberOfWeels = 8,
                NumOfDoors = 1
            };

            Motorcyrcle m1 = new Motorcyrcle
            {
                Model = "mc1",
                NumberOfWeels = 2,
                NumberOfHandBrakes = 2
            };
            Motorcyrcle m2 = new Motorcyrcle
            {
                Model = "mc2",
                NumberOfWeels = 3,
                NumberOfHandBrakes = 4
            };
            Motorcyrcle m3 = new Motorcyrcle
            {
                Model = "mc3",
                NumberOfWeels = 5,
                NumberOfHandBrakes = 10
            };
            VeihcleBase[] veihcles = new VeihcleBase[6] { c1, m1, c2, m2, m3, c3 };
            Carrier carrier = new Carrier(veihcles);
            Console.WriteLine(carrier);
        }
    }
}
