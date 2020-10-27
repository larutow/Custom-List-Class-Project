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
            List<string> testList = new List<string>();

            //CustomList<string> testList = new CustomList<string>();

            testList.Add("hello");
            testList.Add("hi");
            testList.Add("howdy");
            testList.Add("bonjour");
            testList.Add("hola");
            testList.Remove("howdy");

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
