using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_HWS_Interfaces_And_Claesses_Types
{
    public class Carrier
    {
        public VeihcleBase[] Veihcles { get; set; }

        public Carrier(VeihcleBase[] veihcles)
        {
            Veihcles = veihcles;
        }

        public override string ToString()
        {
            string res = "";
            foreach (VeihcleBase curVcl in Veihcles)
            {
                res += curVcl + "\n";
            }

            return res;
        }
    }
}
