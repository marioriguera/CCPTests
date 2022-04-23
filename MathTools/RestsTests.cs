using System.Threading.Tasks;
using ControlClientesProveedores.Tools.Maths;
using Xunit;

namespace CCPTests.MathTools
{
    public class RestsTests
    {
        [Fact]
        public async Task FirstRestTest()
        {
            // Given
            var given = 73;
            // When
            var when = await MathHelpers.GetDoubleRestAsync(89, 16);
            // Then
            Assert.Equal(given, when);
        }
    }
}