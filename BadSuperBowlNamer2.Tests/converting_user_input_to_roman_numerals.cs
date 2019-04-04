using System;
using Xunit;

namespace BadSuperBowlNamer2.Tests
{
    public class converting_user_input_to_roman_numerals
    {
        [Fact]
        public void convert_1_to_I()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 1;
            var expectedResult = "I";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_5_to_V()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 5;
            var expectedResult = "V";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_9_to_IX()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 9;
            var expectedResult = "IX";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_12_to_XII()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 12;
            var expectedResult = "XII";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_16_to_XVI()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 16;
            var expectedResult = "XVI";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_29_to_XXIX()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 29;
            var expectedResult = "XXIX";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_44_to_XLIV()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 44;
            var expectedResult = "XLIV";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_45_to_XLV()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 45;
            var expectedResult = "XLV";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_68_to_LXVIII()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 68;
            var expectedResult = "LXVIII";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_83_to_LXXXIII()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 83;
            var expectedResult = "LXXXIII";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_97_to_XCVII()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 97;
            var expectedResult = "XCVII";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_99_to_XCIX()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input =99;
            var expectedResult = "XCIX";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_500_to_D()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 500;
            var expectedResult = "D";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_501_to_DI()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 501;
            var expectedResult = "DI";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_649_to_DCXLIX()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 649;
            var expectedResult = "DCXLIX";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_798_to_DCCXCVIII()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 798;
            var expectedResult = "DCCXCVIII";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_891_to_DCCXCI()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 891;
            var expectedResult = "DCCCXCI";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_1000_to_M()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 1000;
            var expectedResult = "M";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_1004_to_MIV()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 1004;
            var expectedResult = "MIV";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_1006_to_MVI()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 1006;
            var expectedResult = "MVI";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_1023_to_MXXIII()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 1023;
            var expectedResult = "MXXIII";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_2014_to_MMXIV()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 2014;
            var expectedResult = "MMXIV";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_3999_to_MMMCMXCIX()
        {
            //Arrange
            var convertor = new RomanNumeralConvertor();
            var input = 3999;
            var expectedResult = "MMMCMXCIX";

            //Act
            var actualResult = convertor.ToRoman(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
