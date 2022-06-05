using FluentAssertions;
using PBT_1;
using Xunit;

namespace PBT_1Tests;

public class WhenComparingTwoNumbersInIntComparer
{
    [Fact]
    public void GivenSameNumbers_ShouldBeTrue()
    {
        var sut = new IntComparer();
        var result = sut.AreEqual(22, 22);
        result.Should().BeTrue();
    }
    
    [Fact]
    public void GivenDifferentNumbers_ShouldBeFalse()
    {
        var sut = new IntComparer();
        var result = sut.AreEqual(11, 22);
        result.Should().BeTrue();
    }
}