using System.Threading.Tasks;
using ControlClientesProveedores.Tools.Maths;
using Xunit;

namespace CCPTests.MathTools
{
    public class SumsTests
    {
        /// <summary>
        /// Prueba sencilla de una suma en GetDoubleSumAsync (5+9=14)
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task FirstSumTest()
        {
            // Given
            var given = 14;
            // When
            var when = await MathHelpers.GetDoubleSumAsync(5, 9);
            // Then
            Assert.Equal(given, when);
        }

        /// <summary>
        /// Varias pruebas en linea de sumar dos valores numéricos double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [Theory]
        [InlineData(5, 9)]
        [InlineData(89, 36)]
        [InlineData(12, 3)]
        [InlineData(74, 3)]
        [InlineData(33, 6)]
        [InlineData(13, 89)]
        [InlineData(51, 79)]
        public async Task FirstInlineDataSumTests(double a, double b)
        {
            // Given
            var given = 14;
            // When
            var when = await MathHelpers.GetDoubleSumAsync(a, b);
            // Then
            Assert.Equal(given, when);
        }
    }
}