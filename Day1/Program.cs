namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput input = new GetInput();
            string data = input.Readfile();
            int distancesum = CalcDistance.Distancediff(data);
            Console.WriteLine(distancesum);

            int similiaryscore = CalcSimilarity.SimilarityScore(data);
            Console.WriteLine(similiaryscore);
        }
    }
}
