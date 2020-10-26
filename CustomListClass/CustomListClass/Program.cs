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

            testList.Add(100);
            testList.Add(200);
            testList.Add(300);
            testList.Add(400);

            Console.WriteLine(testList[2]);
            Console.ReadLine();
 
        }
    }
}
