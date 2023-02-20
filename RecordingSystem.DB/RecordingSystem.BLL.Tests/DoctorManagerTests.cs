using Moq;
using RecordingSystem.BLL.Models;
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

        [Test]
        public void GetAllDoctors()
        {
            List<DoctorDto> doctors = new List<DoctorDto>()
            {
                new DoctorDto()
                {
                    Id = 1,
                    Name = "Andrey",
                    LastName = "Strelnikov",
                    Male = true,
                    PhoneNumber = "123",
                    Email = "@ya",
                    SpecializationId = 3,
                    CabinetId = null,
                    IsDeleted = false,
                    Birthday = new DateTime(2001, 05, 20),
                    Specialization = new SpecializationDto()
                    {
                        Id = 1,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetDto()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    }
                }
            };
            _mock.Setup(o => o.GetAllDoctors()).Returns(doctors);

            List<DoctorOutputModel> expected = new List<DoctorOutputModel>()
            {
                new DoctorOutputModel()
                {
                    Id = 1,
                    Name = "Andrey",
                    LastName = "Strelnikov",
                    Male = true,
                    PhoneNumber = "123",
                    Email = "@ya",
                    Birthday = new DateTime(2001, 05, 20),
                    Specialization = new SpecializationDto()
                    {
                        Id = 1,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetDto()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    }
                }
            };

            List<DoctorOutputModel> actual = _doctorManager.GetAllDoctors();

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}