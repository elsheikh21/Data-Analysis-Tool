using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics_Tool
{
    class DataAnalysis
    {
        public double getMaxValue(double[] arr)
        {
            double maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            return maxValue;
        }

        public double getMinValue(double[] arr)
        {
            double minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < minValue)
                    minValue = arr[i];
            return minValue;
        }

        public double findMean(double[] arr)
        {
            double sum = 0;
            int size = arr.Length;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            double avg = sum / size;
            return avg;
        }

        public double findMedian(double[] arr)
        {
            if (arr.Length == 0)
                return -100.0;
            if (arr.Length == 1)
                return arr[0];
            double median;
            if (arr.Length % 2 == 0)
                median = ((double)arr[arr.Length / 2] + (double)arr[arr.Length / 2 - 1]) / 2;
            else
                median = (double)arr[arr.Length / 2];
            return median;
        }

        public double findVariance(double[] arr)
        {
            double mean = findMean(arr);
            double variance = 0.0;
            for (int i = 0; i < arr.Length; i++)
                variance += (arr[i] - mean) * (arr[i] - mean);
            variance /= arr.Length;
            return variance;
        }

        public double findStdDeviation(double[] arr)
        {
            double variance = findVariance(arr);
            double std = Math.Sqrt(variance);
            return std;
        }

        public double findMode(double[] arr)
        {
            double maxValue = 0;
            double maxCount = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                double count = 0;
                for (int j = 0; j < arr.Length; ++j)
                {
                    if (arr[j] == arr[i])
                        ++count;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }

        public double range(double[] arr)
        {
            double min = getMinValue(arr);
            double max = getMaxValue(arr);
            double range = max - min;
            return range;
        }

        public double[] findModes(double[] arr)
        {
            var mode = arr.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key);
            double[] modes = mode.ToArray<Double>();
            return modes;
        }

        public double[] findIQR(double[] arr)
        {
            double q2 = findMedian(arr);
            List<double> list = arr.ToList<double>();
            var list1 = list.Where(x => x < q2);
            var list2 = list.Where(x => x > q2);
            double q1 = findMedian(list1.ToArray<double>());
            double q3 = findMedian(list2.ToArray<double>());
            double iqr = q3 - q1;
            double[] res = new double[] { q1, q2, q3, iqr };
            return res;
        }
    }
}