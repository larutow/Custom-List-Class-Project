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
   
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();

            testList1.Add("a");
            testList1.Add("b");
            testList1.Add("c");
            //testList1 contains: a, b, c
            testList2.Add("3");
            testList2.Add("c");
            testList2.Add("f");
            //testList2 contains: 3, c, f
            
            CustomList<string> foo2 = new CustomList<string> { "one", "two", "three" };
            foreach (string item in foo2)
            {
                Console.WriteLine(item);
            }


            //Output:
            //a, b
            Console.ReadLine();
 
        }
    }
}
