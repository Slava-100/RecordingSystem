using Moq;
using RecordingSystem.BLL.Models;
using RecordingSystem.BLL.Tests.TestCaseSource;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL.Tests
{
    public class ServiceManagerTests
    {
        private ServiceManager _serviceManager;
        private Mock<IServiceRepository> _mock;

        [SetUp]
        public void Setup()
        {
            _serviceManager = new ServiceManager();
            _mock = new Mock<IServiceRepository>();
            _serviceManager.ServiceRepository = _mock.Object;
        }

        [TestCaseSource(typeof(ServiceManagerTestCaseSource), nameof(ServiceManagerTestCaseSource.GetAllServiceByMaleTestCaseSource))]
        public void GetAllServiceByMale(List<ServiceDto> services, List<ServiceOutputModel> expectedService, bool male)
        {
            _mock.Setup(o => o.GetAllServiceByMale(male)).Returns(services).Verifiable();
            List<ServiceOutputModel> expected = expectedService;
            List<ServiceOutputModel> actual = _serviceManager.GetAllServiceByMale(male);
            _mock.VerifyAll();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
