using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceClient.DistanceCalculatorServiceReference;

namespace WCFServiceClient
{
    class Program
    {
        static void Main()
        {
            CalculatorClient calc = new CalculatorClient();

            var result = calc.CalcDistance(new Point { X = 3, Y = 4 },
                new Point { X = 5, Y = 6 });

            Console.WriteLine(result);
        }
    }
}
