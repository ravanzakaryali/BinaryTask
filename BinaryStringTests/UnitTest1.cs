using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using BinaryCheckTask;

namespace BinaryStringTests;

public class BinaryStringTests
{
    [Theory]
    [InlineData("1100", true)]
    [InlineData("1010", true)]
    [InlineData("1001", false)]
    [InlineData("111000", true)]
    [InlineData("0011", false)]
    [InlineData("110", false)]
    [InlineData("abcd", false)]
    public void IsGoodBinaryString_ShouldReturnExpectedResult(string binaryString, bool expected)
    {
        bool result = Algorithms.IsGoodBinaryString(binaryString);
        Assert.Equal(expected, result);
    }
}
