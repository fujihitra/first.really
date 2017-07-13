using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleScript
{
    delegate void MyDelegate(int a, int b);
    class ev
    {
        public event MyDelegate n;
        public void OnSpace(int a,int b)
        {
            n(a, b);
        }
    }
    class Increment
    {
        public void Add(int a, int b)
        {
            int x = a + b;
            Console.WriteLine("デリゲートに格納したAdd関数の出力は" + x);
        }
    }

    class OutPut
    {
        public static void Main()
        {
            string ch;
            ch = Console.ReadLine();
            Console.WriteLine(ch);
            if (ch == " ") {
                Console.WriteLine(ch);
                ev e = new ev();
            Increment tasu = new Increment();
            e.n += new MyDelegate(tasu.Add);
            e.OnSpace(5, 3);
            MyDelegate mydelegate = new MyDelegate(tasu.Add);
         }
            else
            {
                return;
            }
        }
    }
}
