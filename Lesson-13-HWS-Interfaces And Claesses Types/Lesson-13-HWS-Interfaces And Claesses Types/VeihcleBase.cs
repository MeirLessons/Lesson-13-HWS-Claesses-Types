using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_HWS_Interfaces_And_Claesses_Types
{
    public abstract class VeihcleBase
    {
        public string Model { get; set; }
        public int NumberOfWeels { get; set; }

        public abstract int GetMaxNumOfPassangers();
        public abstract double GetMaxSpeed();

        public override string ToString()
        {
            return $"Model: {Model}. Number Of Weels: {NumberOfWeels}";
        }
    }
}
