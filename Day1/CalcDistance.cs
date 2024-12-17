using System;

namespace Day1;

public class CalcDistance
{
    public static int Distancediff(string data)
    {
         List<int> left = new List<int>();
            List<int> right = new List<int>();
            string[] datarows = data.Trim().Split('\n');
            foreach (string row in datarows)
            {
                string num1 = row.Trim().Split(" ",StringSplitOptions.RemoveEmptyEntries)[0];
                string num2 = row.Trim().Split(" ",StringSplitOptions.RemoveEmptyEntries)[1];
                
                int number1 = int.Parse(num1);
                int number2 = int.Parse(num2);
                left.Add(number1);
                right.Add(number2);
            }
            left.Sort();
            right.Sort();

            int sum = 0;

            for (int i = 0; i <left.Count; i++)
            {
                int diff = Math.Abs(left[i] - right[i]);
                sum += diff;
            }
        return sum;
    }

}
