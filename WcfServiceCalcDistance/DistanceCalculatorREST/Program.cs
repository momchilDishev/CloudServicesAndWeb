namespace DistanceCalculatorREST
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using WebApplicationServices.Models;
    class Program
    {
        static void Main()
        {
            using (WebClient client = new WebClient())
            {
                var pointA = new Point() { X = 4, Y = 6 };
                var pointB = new Point() { X = 10, Y = 20 };

                
                
            }
        }
    }
}
