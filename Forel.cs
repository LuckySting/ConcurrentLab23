using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcurrentLab23
{
    public interface IForel
    {
        List<Cluster> Clusterise(List<Point> points, double radius);
        int getProgress();
        void cancel();
    }

    public class SerialForel : IForel
    {
        private int progress = 0;
        private bool stop = false;

        private void updateProgress(int remain, int total)
        {
            progress = (int)Math.Round((double)(total - remain) * 100 / (double)total);
        }

        public void cancel()
        {
            stop = true;
        }
        public int getProgress()
        {
            return progress;
        }

        public List<Cluster> Clusterise(List<Point> points, double radius)
        {
            var result = new List<Cluster>();
            var queue = new List<Point>(points);
            int total = points.Count;
            updateProgress(total, total);
            stop = false;
            while (queue.Count > 0)
            {
                if (stop)
                {
                    break;
                }
                Point point = queue[0];
                queue.RemoveAt(0);
                updateProgress(queue.Count, total);
                var center = new Point(point);
                var cluster = new Cluster(new List<Point>{center}, center);
                while (true)
                {
                    if (stop)
                    {
                        break;
                    }
                    var clusterPoints = queue.Where(p => p.GetDistance(cluster.Center) <= radius).Select(p => p).ToArray();
                    if (clusterPoints.Length == 0)
                    {
                        result.Add(cluster);
                        break;
                    }
                    foreach (var clusterPoint in clusterPoints)
                    {
                        if (stop)
                        {
                            break;
                        }
                        queue.Remove(clusterPoint);
                        cluster.Points.Add(clusterPoint);
                    }
                    cluster.UpdateCenter();
                }
            }

            return result;
        }
    }

    public class ParallelForel : IForel
    {
        private int progress = 0;
        private bool stop = false;

        private void updateProgress(int remain, int total)
        {
            progress = (int)Math.Round((double)(total - remain) * 100 / (double)total);
        }

        public void cancel()
        {
            stop = true;
        }
        public int getProgress()
        {
            return progress;
        }

        public List<Cluster> Clusterise(List<Point> points, double radius)
        {
            var result = new List<Cluster>();
            var queue = new List<Point>(points);
            int total = points.Count;
            updateProgress(total, total);
            stop = false;
            while (queue.Count > 0)
            {
                if (stop)
                {
                    break;
                }
                Point point = queue[0];
                queue.RemoveAt(0);
                updateProgress(queue.Count, total);
                var center = new Point(point);
                var cluster = new Cluster(new List<Point> { center }, center);
                while (true)
                {
                    if (stop)
                    {
                        break;
                    }
                    var clusterPoints = queue.AsParallel().Where(p => p.GetDistance(cluster.Center) <= radius).Select(p => p).ToArray();
                    if (clusterPoints.Length == 0)
                    {
                        result.Add(cluster);
                        break;
                    }
                    foreach (var clusterPoint in clusterPoints)
                    {
                        if (stop)
                        {
                            break;
                        }
                        queue.Remove(clusterPoint);
                        cluster.Points.Add(clusterPoint);
                    }
                    cluster.UpdateCenterParallel();
                }
            }

            return result;
        }
    }
}