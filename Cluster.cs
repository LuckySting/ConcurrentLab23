using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcurrentLab23
{
    public class Cluster
    {
        public List<Point> Points;
        public Point Center;

        public Cluster(List<Point> points, Point center)
        {
            Points = points;
            Center = center;
        }

        public bool UpdateCenter()
        {
            var oldCenter = new Point(Center);
            var newCenter = new Point(Center);
            newCenter.Values = Center.Values.Select((d, v) => Points.Average(p => p.Values[v])).ToArray();
            Center = newCenter;
            return Center == oldCenter;
        }

        public bool UpdateCenterParallel()
        {
            var oldCenter = new Point(Center);
            var newCenter = new Point(Center);
            newCenter.Values = Center.Values.AsParallel().Select((d, v) => Points.AsParallel().Average(p => p.Values[v])).ToArray();
            Center = newCenter;
            return Center == oldCenter;
        }

        public String Print()
        {
            String temp = Center.Print();
            temp += ": [";
            foreach (var point in Points)
            {
                temp += point.Print();
                temp += " ";
            }
            temp += "]";
            return temp;
        }

        public static bool operator ==(Cluster obj1, Cluster obj2)
        {
            return obj1 != null && obj2 != null && obj1.Center == obj2.Center;
        }

        public static bool operator !=(Cluster obj1, Cluster obj2)
        {
            return obj1 != null && obj2 != null && obj1.Center != obj2.Center;
        }
    }
}