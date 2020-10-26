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
            List<int> testList = new List<int>();

            testList.Add(100);
            testList.Add(200);
            testList.Add(300);
            testList.Add(400);
            testList.Add(500);

            testList.Add(100);
            testList.Add(200);
            testList.Add(300);
            testList.Add(400);
            testList.Add(500);
            testList.Add(100);
            testList.Add(200);
            testList.Add(300);
            testList.Add(400);
            testList.Add(500);

        }
    }
}
