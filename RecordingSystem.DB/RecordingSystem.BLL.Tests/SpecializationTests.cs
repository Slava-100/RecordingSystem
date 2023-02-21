using Moq;
using RecordingSystem.BLL.Models;
using RecordingSystem.BLL.Tests.TestCaseSource;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Tests
{
    public class SpecializationTests
    {
        private SpecializationManager _specializationManager;
        private Mock<ISpecializationRepository> _mock;


        [SetUp]
        public void Setup()
        {
            _specializationManager = new SpecializationManager();
            _mock = new Mock<ISpecializationRepository>();
            _specializationManager.SpecializationRepository = _mock.Object;
        }

        [TestCaseSource(typeof(SpecializationTestCaseSource), nameof(SpecializationTestCaseSource.GetAllSpecializationsTestCaseSource))]
        public void GetAllSpecializationsTest(List<SpecializationDto> specializations, List<SpecializationOutputModel> expectedSpecializations)
        {
            _mock.Setup(o => o.GetAllSpecializations()).Returns(specializations).Verifiable();
            List<SpecializationOutputModel> expected = expectedSpecializations;
            List<SpecializationOutputModel> actual = _specializationManager.GetAllSpecializations();
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SpecializationTestCaseSource), nameof(SpecializationTestCaseSource.AddSpecializationTestCaseSource))]
        public void AddSpecializationTest(SpecializationInputModel inputSpecializations, SpecializationInputModel expectedResult)
        {
            _specializationManager.AddSpecialization(inputSpecializations);
            SpecializationInputModel expected = expectedResult;
            SpecializationInputModel actual = inputSpecializations;
            Assert.AreEqual(expected, actual);
        }
    }
}
