using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Console_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int x1 = 100;
            int x2 = 200;
            int x3 = 300;
            list.Add(x1);
            list.Add(x2);
            list.Add(x3);
            int c = list.Count;
            list.RemoveAt(200);
            list.Remove(200);
            list.RemoveRange(1, 2);
            c = list.Count;
            //int y1 = Convert.ToInt32(list[0]);
            int y1 = Convert.ToInt32(list[1]);
            Console.WriteLine(y1);
            Console.ReadLine();
        }
    }
}
