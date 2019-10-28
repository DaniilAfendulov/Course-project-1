using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Classes
{
    public class PetComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Pet && y is Pet)
            {
                return (int)((Pet)x).Attack- (int)((Pet)y).Attack;
            }
            return 0;
        }
    }
}
