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

            CustomList<string> testList = new CustomList<string>();

            testList.Add("one");
            testList.Add("two");
            testList.Add("three");
            testList.Add("four");
            testList.Add("five");

            //bool succ = testList.Remove(300);
            //bool succ2 = testList.Remove(200);
            //bool fail = testList.Remove(50);

            Console.WriteLine(testList[0]);
            Console.WriteLine(testList[1]);
            Console.WriteLine(testList[2]);


            Console.ReadLine();
 
        }
    }
}
