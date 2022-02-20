using System;
using Xunit;
using Num2WordApp.Core;

namespace Num2WordAppTest.Core
{
    public class WriteNumberTest
    {
        [Fact]
        public void Should_WriteNumberAsWord_Throws_ArgumentOutOfRangeException()
        {
            //Arrange
            var number = 12;
            var languageCode = 55;
            
            //Act && Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => WriteNumber.WriteNumberAsWord(number, languageCode));
        }

        [Fact]
        public void Should_WriteNumberAsWord_Return_A_String_That_Represents_A_Number_As_Word_In_English()
        {
            //Arrange
            var number = 12;
            var languageCode = 1;
            var expectedNumberAsWord = "twelve";
            
            //Act
            var actualNumberAsWord = WriteNumber.WriteNumberAsWord(number, languageCode);
            
            //Assert
            Assert.Equal(expectedNumberAsWord, actualNumberAsWord);
        }

        [Fact]
        public void Should_WriteNumberAsWord_Return_A_String_That_Represents_A_Number_As_Word_In_Portuguese()
        {
            //Arrange
            var number = 12;
            var languageCode = 2;
            var expectedNumberAsWord = "doze";
            
            //Act
            var actualNumberAsWord = WriteNumber.WriteNumberAsWord(number, languageCode);

            //Assert
            Assert.Equal(expectedNumberAsWord, actualNumberAsWord);
        }
    }
}