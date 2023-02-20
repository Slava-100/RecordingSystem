using Moq;
using RecordingSystem.BLL.Models;
using RecordingSystem.BLL.Tests.TestCaseSource;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Tests
{
    public class PatientManagerTests
    {
        private PatientManager _patientManager;
        private Mock<IPatientRepository> _mock;

        [SetUp]
        public void Setup()
        {
            _patientManager = new PatientManager();
            _mock = new Mock<IPatientRepository>();
            _patientManager.PatientRepository = _mock.Object;
        }

        [TestCaseSource(typeof(PatientManagerTestCaseSource), nameof(PatientManagerTestCaseSource.GetAllPatientsTestCaseSource))]
        public void GetAllPatientsTest(List<PatientDto> patients, List<PatientOutputModel> expectedPatients)
        {
            _mock.Setup(o => o.GetAllPatients()).Returns(patients).Verifiable();
            List<PatientOutputModel> expected = expectedPatients;
            List<PatientOutputModel> actual = _patientManager.GetAllPatients();
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(PatientManagerTestCaseSource), nameof(PatientManagerTestCaseSource.GetAllPatientsByStatusIdTestCaseSource))]
        public void GetAllPatientsByStatusIdTest(int id, List<PatientDto> patients, List<PatientOutputModel> expectedPatients)
        {
            _mock.Setup(o => o.GetAllPatientsByStatusId(id)).Returns(patients).Verifiable();
            List<PatientOutputModel> expected = expectedPatients;
            List<PatientOutputModel> actual = _patientManager.GetAllPatientsByStatusId(id);
            _mock.VerifyAll();
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestCaseSource(typeof(PatientManagerTestCaseSource), nameof(PatientManagerTestCaseSource.AddPatientTestCaseSource))]
        public void AddPatientTest(PatientInputModel inputPatient, PatientInputModel expectedResult)
        {
            _patientManager.AddPatient(inputPatient);
            PatientInputModel expected = expectedResult;
            PatientInputModel actual = inputPatient;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(PatientManagerTestCaseSource), nameof(PatientManagerTestCaseSource.UpdatePatientTestCaseSource))]
        public void UpdatePatientTest(PatientInputModel inputPatient, PatientInputModel expectedResult)
        {
            _patientManager.UpdatePatient(inputPatient);
            PatientInputModel expected = expectedResult;
            PatientInputModel actual = inputPatient;
            Assert.AreEqual(expected, actual);
        }
    }
}