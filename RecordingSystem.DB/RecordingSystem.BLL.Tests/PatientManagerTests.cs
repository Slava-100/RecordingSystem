using Moq;
using RecordingSystem.BLL.Models;
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

        [Test]
        public void GetAllPatients()
        {
            List<PatientDto> patients = new List<PatientDto>()
            {
                new PatientDto()
                {
                    Id= 1,
                    Name = "wwwwwww",
                    LastName = "",
                    Birthday = new DateTime(2001, 01, 01),
                    PhoneNumber = "123123",
                    Email = "@",
                    StatusId = 1,
                    Male = true,
                    IsDeleted= false,
                    Status = new StatusDto()
                    {
                        Id = 1,
                        Name = "Invalid",
                        Discount= 70

                    }
                }
            };
            _mock.Setup(o => o.GetAllPatients()).Returns(patients);

            List<PatientOutputModel> expected = new List<PatientOutputModel>()
            {
                new PatientOutputModel()
                {
                    Id= 1,
                    Name = "wwwwwww",
                    LastName = "",
                    Birthday = new DateTime(2001, 01, 01),
                    PhoneNumber = "123123",
                    Email = "@",
                    StatusId = 1,
                    Male = true,
                    Status = new StatusDto()
                    {
                        Id = 1,
                        Name = "Invalid",
                        Discount= 70
                    }
                }
            };

            List< PatientOutputModel> actual = _patientManager.GetAllPatients();

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}