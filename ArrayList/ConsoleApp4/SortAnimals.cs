using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class SortAnimals : IComparer
    {
        public int Compare(object x, object y)
        {
            Animals a1 = x as Animals;
            Animals a2 = y as Animals;

            if (a1 == null || a2 == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                if (a1.Age > a2.Age)
                    return 1;
                else if (a1.Age == a2.Age)
                    return 0;
                else return -1;
            }
        }
    }
}
