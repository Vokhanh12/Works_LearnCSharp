using System;
using System.Collections;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals("Tom", "Green", 18);
            Animals dog = new Animals("koko", "Green", 30);
            Animals tiger = new Animals("aoao", "Green", 22);

            ArrayList arrAnimals = new ArrayList();
            arrAnimals.Add(cat);
            arrAnimals.Add(dog);
            arrAnimals.Add(tiger);

            foreach(Animals item in arrAnimals)
            {
                Console.WriteLine("" + item.ToString());
            }

            arrAnimals.Sort(new SortAnimals());

            foreach (Animals item in arrAnimals)
            {
                Console.WriteLine("" + item.ToString());
            }




        }
    }
}
