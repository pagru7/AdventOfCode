using Xunit;

namespace AoC._2023.Day01.Tests
{
    public class TrebuchetTests
    {
        private readonly Trebuchet _trebuchet;

        public TrebuchetTests()
        {
            _trebuchet = new Trebuchet();
        }

        [Theory()]
        [InlineData(new string[] { "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet" }, 142)]
        public void CalibrateTest(string[] input, int result)
        {
            // Act
            int calibration = _trebuchet.Calibrate(input);

            // Assert
            Assert.Equal(result, calibration);
        }

        [Theory()]
        [InlineData("1abc2", 12)]
        [InlineData("pqr3stu8vwx", 38)]
        [InlineData("a1b2c3d4e5f", 15)]
        [InlineData("treb7uchet", 77)]
        [InlineData("trebuchet", 0)]
        public void CalibrateSingleString_ReturnsExpected(string input, int result)
        {
            Assert.Equal(result, _trebuchet.Calibrate(input));
        }

        [Fact]
        public void Calibrate_EmptyString_ReturnsZero()
        {
            Assert.Equal(0, _trebuchet.Calibrate(string.Empty));
        }

        [Fact]
        public void Calibrate_InputFile_ReturnsExptected()
        {
            // Arrange
            string[] input = System.IO.File.ReadAllLines("Day01/Day01Input.txt");

            // Act
            int calibration = _trebuchet.Calibrate(input);

            // Assert
            Assert.Equal(54601, calibration);
        }
    }
}