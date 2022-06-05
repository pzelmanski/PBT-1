using FluentAssertions;
using FsCheck.Xunit;
using PBT_1;

namespace PBT_1Tests
{
    public class PropertyBasedWhenComparing
    {
        [Property]
        public void GivenInteger_ItShouldReturnTrue(int numberToCompare)
        {
            var sut = new IntComparer();
            var result = sut.AreEqual(numberToCompare, numberToCompare);
            if(numberToCompare is >= 1 and <= 10)
                result.Should().BeFalse();
            else
                result.Should().BeTrue();
        }
    }
}