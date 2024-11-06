using Xunit;
using MyApp;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = Program.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
