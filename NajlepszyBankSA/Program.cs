using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    class Program
    {
        static void Main(string[] args)
        {
            AspectTest test = new AspectTest();
            test.DoSmth();
            Console.ReadKey();
        }

        [Serializable]
        public class AspectTest
        {
            [AspectBanking]
            public void DoSmth()
            {
                Console.WriteLine("Doing smth");
                throw new Exception("I protest! I do not want to do anything anymore");
            }

            [Serializable]
            public class AspectBanking : OnMethodBoundaryAspect
            {
                public override void OnEntry(MethodExecutionArgs args)
                {
                    Console.WriteLine("On entry");
                }

                public override void OnException(MethodExecutionArgs args)
                {
                    Console.WriteLine("On exception");
                    Console.WriteLine(args.Exception.Message);
                    Console.WriteLine(args.Exception.StackTrace);
                    args.FlowBehavior = FlowBehavior.RethrowException;
                }

                public override void OnExit(MethodExecutionArgs args)
                {
                    Console.WriteLine("On exit");
                }

            }
        }
    }
}
