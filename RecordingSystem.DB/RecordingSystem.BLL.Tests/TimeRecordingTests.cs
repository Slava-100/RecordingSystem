using Moq;
using RecordingSystem.BLL.Models;
using RecordingSystem.BLL.Tests.TestCaseSource;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Tests
{
    public class TimeRecordingTests
    {
        private TimeRecordingManager _timeRecordingManager;
        private Mock<ITimeRecordingRepository> _mock;

        [SetUp]
        public void Setup()
        {
            _timeRecordingManager = new TimeRecordingManager();
            _mock = new Mock<ITimeRecordingRepository>();
            _timeRecordingManager.TimeRecordingRepository = _mock.Object;
        }

        [TestCaseSource(typeof(TimeRecordingsTestCaseSource), nameof(TimeRecordingsTestCaseSource.GetAllTimeRecordingsByDoctorIdTestCaseSource))]
        public void GetAllTimeRecordingsByDoctorId(int id, List<TimeRecordingDto> timeRecordings, List<TimeRecordingOutputModel> expectedTimeRecordings)
        {
            _mock.Setup(o => o.GetAllTimeRecordingsByDoctorId(id)).Returns(timeRecordings).Verifiable();
            List<TimeRecordingOutputModel> expected = expectedTimeRecordings;
            List<TimeRecordingOutputModel> actual = _timeRecordingManager.GetAllTimeRecordingsByDoctorId(id);
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
