using System.Threading.Tasks;
using ControlClientesProveedores.Services.Core.Interfaces;
using ControlClientesProveedores.Services.Models.DTOs;
using Xunit;
using Moq;

namespace CCPTests.Services
{
    public class CreadorMockTest
    {
        [Fact]
        private async Task<ICreadorService> prvGetMockCreadorService()
        {
            Mock<ICreadorService> mockObject = new Mock<ICreadorService>();

            CreadorWebDTO creador = new CreadorWebDTO()
            {
                Nombre = "Mario David Riguera Castillo"
            };

            mockObject.Setup(m => m.GetCreadorAsync()).ReturnsAsync(creador);
            return mockObject.Object;
        }

        [Fact]
        public async Task FirstTestMethod()
        {
            ICreadorService mockCreador = await this.prvGetMockCreadorService();
            CreadorWebDTO creador = await mockCreador.GetCreadorAsync();

            Assert.Equal("Mario David Riguera Castillo", creador.Nombre);
        }
    }
}