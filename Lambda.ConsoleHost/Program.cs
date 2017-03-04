using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Lambda.Host.LambdaHost.Instance.Open();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Lambda.Host.LambdaHost.Instance.Close();
        }
    }
}
