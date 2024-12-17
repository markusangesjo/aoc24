using System;

namespace Day1;

public class CalcSimilarity
{
    public static int SimilarityScore(string data)
    {
        int score = 0;
            List<int> left = [];
            List<int> right = [];
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

            foreach (int value in left)
            {
                int count = 0;
                foreach (int number in right)
                {
                    if (value == number)
                    {
                        count++;
                    }
                }
                score = score + ( value*count);
            }
        return score;
    }

}
