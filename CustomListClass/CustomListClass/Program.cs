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
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            CustomList<string> testList4;
            testList1.Add("yo 1-1");
            testList1.Add("boo 1-2");
            testList1.Add("duh 1-3");
            testList2.Add("yo 2-1");
            testList2.Add("ree 2-2");


            testList3 = testList1 + testList2;
            testList3.Add("safe 3-1");
            testList3.Add("sound 3-2");
            testList4 = testList3 - testList2;

            Console.WriteLine(testList4.ToString());

            //bool succ = testList.Remove(300);
            //bool succ2 = testList.Remove(200);
            //bool fail = testList.Remove(50);

            Console.ReadLine();
 
        }
    }
}
