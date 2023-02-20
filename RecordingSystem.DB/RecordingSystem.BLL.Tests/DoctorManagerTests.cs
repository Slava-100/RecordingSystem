using Moq;
using RecordingSystem.BLL.Models;
using RecordingSystem.BLL.Tests.TestCaseSource;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Tests
{
    public class DoctorManagerTests
    {
        private DoctorManager _doctorManager;
        private Mock<IDoctorRepository> _mock;

        [SetUp]
        public void Setup()
        {
            _doctorManager = new DoctorManager();
            _mock = new Mock<IDoctorRepository>();
            _doctorManager.DoctorRepository = _mock.Object;
        }

        [TestCaseSource(typeof(DoctorManagerTestCaseSource), nameof(DoctorManagerTestCaseSource.GetAllDoctorsTestCaseSource))]
        public void GetAllDoctors(List<DoctorDto> doctors, List<DoctorOutputModel> expectedDoctors)
        {
            _mock.Setup(o => o.GetAllDoctors()).Returns(doctors).Verifiable();
            List<DoctorOutputModel> expected = expectedDoctors;
            List<DoctorOutputModel> actual = _doctorManager.GetAllDoctors();
            _mock.VerifyAll();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}