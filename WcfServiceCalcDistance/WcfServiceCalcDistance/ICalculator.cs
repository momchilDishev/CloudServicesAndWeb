using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalcDistance
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        long Sum(int a, int b);

        [OperationContract]
        double CalcDistance(Point startpoint, Point endpoint);

    }
    [DataContract]
    public class Point
    {
        [DataMember]
        public int X { get; set; }

        [DataMember]
        public int Y { get; set; }
    }
}
