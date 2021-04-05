using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentLab23
{
    public class Point
    {
        public double[] Values;
        public Point(double[] values)
        {
            Values = values;
        }
        
        public Point(Point point)
        {
            double[] valuesCopy = new double[point.Values.Length];
            point.Values.CopyTo(valuesCopy, 0);
            Values = valuesCopy;
        }

        public String Print()
        {
            String temp = "";
            temp += "{ ";
            foreach (var value in Values)
            {
                temp += value;
                temp += " ";
            }
            temp += "}";
            return temp;
        }

        public double GetDistance(Point obj)
        {
            if (Values.Length == 0)
            {
                return 0;
            }
            if (Values.Length != obj.Values.Length)
            {
                return 0;
            }
            double distSquared = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                double squareDist = Math.Pow(Values[i] - obj.Values[i], 2);
                distSquared += squareDist;
            }
            return Math.Pow(distSquared, 0.5);
        }

        public static bool operator==(Point obj1, Point obj2)
        {
            return !object.ReferenceEquals(obj1, null) && !object.ReferenceEquals(obj2, null) 
                && (object.ReferenceEquals(obj1, obj2) || obj1.GetDistance(obj2) == 0);
        }
        
        public static bool operator!=(Point obj1, Point obj2)
        {
            return !(obj1 == obj2);
        }
    }
}