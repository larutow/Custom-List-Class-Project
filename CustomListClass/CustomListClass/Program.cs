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
            testList1.Add("yo");
            testList1.Add("boo");
            testList1.Add("duh");
            testList2.Add("hi");
            testList2.Add("ree");
            testList3 = testList1 + testList2;
            Console.WriteLine(testList3.ToString());



            //bool succ = testList.Remove(300);
            //bool succ2 = testList.Remove(200);
            //bool fail = testList.Remove(50);

            Console.ReadLine();
 
        }
    }
}
