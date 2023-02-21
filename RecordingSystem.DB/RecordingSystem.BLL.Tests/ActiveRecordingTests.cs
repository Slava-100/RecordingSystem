using Moq;
using RecordingSystem.BLL.Models;
using RecordingSystem.BLL.Tests.TestCaseSource;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Tests
{
    public class ActiveRecordingTests
    {
        private ActiveRecordingManager _activeRecordingManager;
        private Mock<IActiveRecordingRepository> _mock;

        [SetUp]
        public void Setup()
        {
            _activeRecordingManager = new ActiveRecordingManager();
            _mock = new Mock<IActiveRecordingRepository>();
            _activeRecordingManager.ActiveRecordingRepository = _mock.Object;
        }

        [TestCaseSource(typeof(ActiveRecordingTestCaseSource), nameof(ActiveRecordingTestCaseSource.GetAllActiveRecordingsByPatientIdTestCaseSource))]
        public void GetAllActiveRecordingsByPatientIdTest(int id, List<ActiveRecordingDto> activeRecordings, List<ActiveRecordingOutputModel> expectedActiveRecordings)
        {
            _mock.Setup(o => o.GetAllActiveRecordingsByPatientId(id)).Returns(activeRecordings).Verifiable();
            List<ActiveRecordingOutputModel> expected = expectedActiveRecordings;
            List<ActiveRecordingOutputModel> actual = _activeRecordingManager.GetAllActiveRecordingsByPatientId(id);
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ActiveRecordingTestCaseSource), nameof(ActiveRecordingTestCaseSource.AddActiveRecordingTestCaseSource))]
        public void AddActiveRecordingTest(ActiveRecordingInputModel inputActiveRecording, ActiveRecordingInputModel expectedResult)
        {
            _activeRecordingManager.AddActiveRecording(inputActiveRecording);
            ActiveRecordingInputModel expected = expectedResult;
            ActiveRecordingInputModel actual = inputActiveRecording;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ActiveRecordingTestCaseSource), nameof(ActiveRecordingTestCaseSource.UpdateActiveRecordingTestCaseSource))]
        public void UpdateActiveRecordingTest(UpdateActiveRecordingModel updateActiveRecording, UpdateActiveRecordingModel expectedResult)
        {
            _activeRecordingManager.UpdateComingInActiveRecordingById(updateActiveRecording);
            UpdateActiveRecordingModel expected = expectedResult;
            UpdateActiveRecordingModel actual = updateActiveRecording;
            Assert.AreEqual(expected, actual);
        }
    }
}
