using System;

namespace Day1;

public class GetInput
{
    string filePath = "../../../input.txt";
    public string Readfile()
    {
        string content = File.ReadAllText(filePath);
        return content;
    }
}
