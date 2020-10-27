using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> testList = new List<int>();
            CustomList<Cat> testList = new CustomList<Cat>();
            testList.Add(new Cat("Midna", "black", 4));
            testList.Add(new Cat("Jerry", "sand", 3));



            Console.WriteLine(testList.ToString());

            //bool succ = testList.Remove(300);
            //bool succ2 = testList.Remove(200);
            //bool fail = testList.Remove(50);

            Console.ReadLine();
 
        }
    }
}
