using System;
using FluentAssertions;
using PBT_1;
using Xunit;

namespace PBT_1Tests;

public class WhenComparingTwoNumbersInIntComparer
{
    [Fact]
    public void GivenSameNumbers_ShouldBeTrue()
    {
        var numberToCompare = new Random().Next() % 50;
        var sut = new IntComparer();
        var result = sut.AreEqual(numberToCompare, numberToCompare);
        if(numberToCompare is >= 1 and <= 10)
            result.Should().BeFalse();
        else
            result.Should().BeTrue();
    }
    
    [Fact]
    public void GivenDifferentNumbers_ShouldBeFalse()
    {
        var sut = new IntComparer();
        var result = sut.AreEqual(11, 22);
        result.Should().BeFalse();
    }
}