namespace BinaryCheckTask;
public class Program
{
    static void Main()
    {
        Console.Write("Please enter binary numbers: ");
        string? binaryString = Console.ReadLine();
        if (string.IsNullOrEmpty(binaryString))
        {
            Console.WriteLine("Please enter a valid binary number.");
            return;
        }
        bool isGood = Algorithms.IsGoodBinaryString(binaryString);
        Console.WriteLine($"Dizi '{binaryString}' {(isGood ? "good" : "not good")}");

        RunTests();
    }



    public static void RunTests()
    {
        string[] testCases = { "1100", "1010", "1001", "111000", "0011", "110", "abcd" };
        bool[] expectedResults = { true, true, false, false, false, false, false };

        Console.WriteLine("\nRunning Tests...");
        for (int i = 0; i < testCases.Length; i++)
        {
            bool result = Algorithms.IsGoodBinaryString(testCases[i]);
            Console.WriteLine($"Test Case {i + 1}: '{testCases[i]}' - Expected: {expectedResults[i]}, Got: {result}");
        }
    }
}
