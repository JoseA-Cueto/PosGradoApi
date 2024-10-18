using Moq;
using AutoMapper;
using PosgradoAPI.BusinessLayer.Service;
using PosgradoAPI.DataLayer.RepositoriesInterfaces;
using Xunit;
using PosgradoAPI.Core.DTOs;
using PosgradoAPI.Core.Models;
using PosgradoAPI.DataLayer.Repositories;
using PosgradoAPI.DataBaseContext;

namespace PosgradoAPI.Test
{
    public class Tests
    {
        public Tests()
        {            
        }

        [Fact]
        public void  TestUnit()
        {         
            var mockRepository = new Mock<IProfessionalRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockProfessorRepository = new Mock<IProfessorRepository>();

            var func = new ProfessionalService(mockRepository.Object, mockMapper.Object, mockProfessorRepository.Object);
            var response = func.GetAllAsync();
            Assert.NotNull(response);
        }

        [Fact]
        public void TestUnit1()
        {

            var mockRepository = new Mock<AppDbContext>();
            var func = new ProfessionalRepository(mockRepository.Object);
            var response = func.GetAllAsync();
            Assert.NotNull(response);
        }
    }
}
