using FluentAssertions;
using RomanNumerals;


namespace RomanNumeralsTests
{
    public class ConverterTests
    {
        private Converter converter;

        [SetUp]
        public void Setup()
        {
           converter = new Converter();
        }

        [Test]
        public void Should_Return_Invalid_Given_0()
        {
            converter.Convert(0).Should().Be("Invalid. Enter number greater than 0.");
           
        }

        [Test]
        public void Should_Return_I_Given_1()
        {
            converter.Convert(1).Should().Be("I");

        }

        [Test]
        public void Should_Return_X_Given_10()
        {
            converter.Convert(10).Should().Be("X");

        }

        [Test]
        public void Should_Return_500_Given_D()
        {
            converter.Convert(500).Should().Be("D");

        }

        [Test]
        public void Should_Return_7_Given_VII()
        {
            converter.Convert(7).Should().Be("VII");

        }
        [Test]
        public void Should_Return_8_Given_VIII()
        {
            converter.Convert(8).Should().Be("VIII");

        }


        [Test]
        public void Should_Return_9_Given_IX()
        {
            converter.Convert(9).Should().Be("IX");

        }
    }
}