using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// How to store n number of lists of different types in a single generic list using youtube video below
//   https://www.youtube.com/watch?v=8xd4swn5dM8&list=PL6n9fhu94yhWlAv3hnHzOaMSeggILsZFs&index=7
// make a list of (list of objects)

//This comment is addet to test commit to Git

namespace Interview_Questions7
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<List<object>> list = new List<List<object>>();

            List<object> List1 = new List<object>();
            List1.Add(101);
            List1.Add(102);
            List1.Add(103);
            List1.Add(104);

            List<object> List2 = new List<object>();
            List2.Add("Test1");
            List2.Add("Test2");
            List2.Add("Test3");

            list.Add(List1);
            list.Add(List2);

            foreach(List<object> objectlist in list)
            {
                foreach(object obj in objectlist)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }
        }
    }
}
