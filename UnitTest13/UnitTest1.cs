using AutoMapper;
using Moq;
using PosgradoAPI.BusinessLayer.Service;
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
            var mockRepository = new Mock<IProfessionalRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockProfessorRepository = new Mock<IProfessorRepository>();

            var func = new ProfessionalService(mockRepository.Object, mockMapper.Object, mockProfessorRepository.Object);
            var response = func.GetAllAsync();
            Assert.NotNull(response);
        }
    }
}