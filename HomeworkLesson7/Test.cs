using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson7
{
    internal class Test
    {
        private Test() { }

        public static void TestCoder()
        {
            var coderA = new ACoder("Alex");

            Console.WriteLine(coderA);
            coderA.Encode();
            Console.WriteLine(coderA);

            coderA.Decode();
            Console.WriteLine(coderA);

            Console.WriteLine("==================================");

            var coder = new BCoder("ALEX");
            Console.WriteLine(coder);

            coder.Encode();
            Console.WriteLine(coder);

            coder.Decode();
            Console.WriteLine(coder);

            Console.WriteLine("==================================");

            var coder1 = new BCoder("alex");
            Console.WriteLine(coder1);

            coder1.Encode();
            Console.WriteLine(coder1);

            coder1.Decode();
            Console.WriteLine(coder1);
        }
    }
}
