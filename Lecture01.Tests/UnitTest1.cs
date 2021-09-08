using System;
using System.IO;
using Xunit;
using Lecture01;

namespace Lecture01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void main_isLeapYearTrue()
        {

            var output = false;

            output = Program.isLeapYear(2000);

            Assert.True(output);                
        }

        [Fact]
        public void print_nay()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2001");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);         

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);

        }

        [Fact]
        public void print_exception()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1234");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);         

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Year must be from 1582 or later", output);

        }
    }
}


