using System;
using Xunit;

namespace DataWorks.Converter.Test
{
    public class RomanToIntTest
    {
        [Fact]
        public void InvalidRomanItemRomanToInt()
        {
            //Arrange
            RomanToInt romanToInt = new RomanToInt();
            //Act
            string roman = "LILB";
            //Assert
            Assert.Equal(-1, romanToInt.RomanToInteger(roman));
        }
        [Fact]
        public void EmptyRomanToInt()
        {
            //Arrange
            RomanToInt romanToInt = new RomanToInt();
            //Act
            string roman = "";
            //Assert
            Assert.Equal(0, romanToInt.RomanToInteger(roman));
        }
        [Fact]
        public void InvalidRomanRomanToInt()
        {
            //Arrange
            RomanToInt romanToInt = new RomanToInt();
            //Act
            string roman = "IXX";
            //Assert
            Assert.Equal(-2, romanToInt.RomanToInteger(roman));
        }
        [Fact]
        public void OutOfRangeRomanToInt()
        {
            //Arrange
            RomanToInt romanToInt = new RomanToInt();
            //Act
            string roman = "MMMM";
            //Assert
            Assert.Equal(-3, romanToInt.RomanToInteger(roman));
        }
        [Fact]
        public void ValidRomanToInt()
        {
            //Arrange
            RomanToInt romanToInt = new RomanToInt();
            //Act
            string roman = "XCIX";
            //Assert
            Assert.Equal(99, romanToInt.RomanToInteger(roman));
        }

    }
}
