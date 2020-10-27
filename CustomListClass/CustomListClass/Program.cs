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
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);

            
            Console.WriteLine(testList.ToString());

            //bool succ = testList.Remove(300);
            //bool succ2 = testList.Remove(200);
            //bool fail = testList.Remove(50);

            Console.ReadLine();
 
        }
    }
}
