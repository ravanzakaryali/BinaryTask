namespace BinaryCheckTask;

public static class Algorithms
{
    public static bool IsGoodBinaryString(string binaryString)
    {
        int zeroCount = 0;
        int oneCount = 0;

        foreach (char c in binaryString)
        {
            if (c != '0' && c != '1')
                return false;

            if (c == '0')
                zeroCount++;
            else
                oneCount++;

            if (oneCount < zeroCount)
                return false;
        }

        return zeroCount == oneCount;
    }

}