using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_HWS_Interfaces_And_Claesses_Types
{
    class Car : VeihcleBase
    {
        public int NumOfDoors { get; set; }
        public override int GetMaxNumOfPassangers()
        {
            return 4;
        }

        public override double GetMaxSpeed()
        {
            return 212.20;
        }

        public override string ToString()
        {
            return base.ToString() + $" Doors: {NumOfDoors}.";
        }
    }

    class Motorcyrcle : VeihcleBase
    {
        public int NumberOfHandBrakes { get; set; }
        public override int GetMaxNumOfPassangers()
        {
            return 2;
        }

        public override double GetMaxSpeed()
        {
            return 167.5;
        }

        public override string ToString()
        {
            return base.ToString() + $" Hand Brakes: {NumberOfHandBrakes}.";
        }
    }
}
