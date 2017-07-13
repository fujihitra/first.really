using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleScript
{

    delegate int MyDelegate(int a, int b);

    class Increment
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
    }

    class OutPut
    {
        public static void Main()
        {
            Increment tasu = new Increment();
            Console.WriteLine("そのまま呼び出しのAdd関数の出力は"+tasu.Add(5,3));
            MyDelegate mydelegate =(a,b)=> tasu.Add(a,b);
            Console.WriteLine("デリゲートに格納したAdd関数の出力は"+mydelegate(5,3));
        }
    }
}
