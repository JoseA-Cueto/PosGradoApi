using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using PosgradoAPI.BusinessLayer.Service;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;

namespace UnitTest13
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            
        }
        [Fact]
        public void TestUnit()
        {
            var mockRepository = new Mock<IActividadRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockProfessorRepository = new Mock<ILogger<ActividadDTO>>();

            var func = new ActividadService(mockRepository.Object, mockMapper.Object, mockProfessorRepository.Object);
            var response = func.GetAllAsync();
            Assert.NotNull(response);
        }
    }
}