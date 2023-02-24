using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Tests.TestCaseSource
{
    public static class PatientManagerTestCaseSource
    {
        public static IEnumerable GetAllPatientsTestCaseSource()
        {
            List<PatientDto> patients = new List<PatientDto>()
            {
                new PatientDto()
                {
                    Id= 1,
                    Name = "wwwwwww",
                    LastName = "qqqq",
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

            List<PatientOutputModel> expected = new List<PatientOutputModel>()
            {
                new PatientOutputModel()
                {
                    Id= 1,
                    Name = "wwwwwww",
                    LastName = "qqqq",
                    Birthday = new DateTime(2001, 01, 01),
                    PhoneNumber = "123123",
                    Email = "@",
                    StatusId = 1,
                    Male = true,
                    Status = new StatusOutputModel()
                    {
                        Id = 1,
                        Name = "Invalid",
                        Discount= 70
                    }
                }
            };

            yield return new Object[] { patients, expected };
        }

        public static IEnumerable GetAllPatientsByStatusIdTestCaseSource()
        {
            List<PatientDto> patients = new List<PatientDto>()
            {
                new PatientDto()
                {
                    Id= 1,
                    Name = "wwwwwww",
                    LastName = "qqqq",
                    Birthday = new DateTime(2001, 01, 01),
                    StatusId = 1,
                    Male = true,
                    Status = new StatusDto()
                    {
                        Id = 1,
                        Name = "Invalid",
                    }
                }
            };

            List<PatientOutputModel> expectedPatients = new List<PatientOutputModel>()
            {
                new PatientOutputModel()
                {
                    Id= 1,
                    Name = "wwwwwww",
                    LastName = "qqqq",
                    Birthday = new DateTime(2001, 01, 01),
                    StatusId = 1,
                    Male = true,
                    Status = new StatusOutputModel()
                    {
                        Id = 1,
                        Name = "Invalid",
                    }
                }
            };

            int id = 1;

            yield return new Object[] { id, patients, expectedPatients };

            id = 2;

            patients = new List<PatientDto>();

            expectedPatients = new List<PatientOutputModel>();

            yield return new Object[] { id, patients, expectedPatients };
        }

        public static IEnumerable AddPatientTestCaseSource()
        {
            PatientInputModel inputPatient = new PatientInputModel()
            {
                Id = 1,
                Name = "wwwwwww",
                LastName = "qqqq",
                Birthday = new DateTime(2001, 01, 01),
                PhoneNumber = "123123",
                Email = "@",
                StatusId = 1,
                Male = true,
            };
            PatientInputModel expectedResult = new PatientInputModel() 
            {
                Id = 1,
                Name = "wwwwwww",
                LastName = "qqqq",
                Birthday = new DateTime(2001, 01, 01),
                PhoneNumber = "123123",
                Email = "@",
                StatusId = 1,
                Male = true,
            };

            yield return new Object[] { inputPatient, expectedResult };
        }

        public static IEnumerable UpdatePatientTestCaseSource()
        {
            PatientInputModel inputPatient = new PatientInputModel()
            {
                Id = 1,
                Name = "wwwwwww",
                LastName = "qqqq",
                Birthday = new DateTime(2001, 01, 01),
                PhoneNumber = "123123",
                Email = "@",
                StatusId = 1,
                Male = true,
            };
            PatientInputModel expectedResult = new PatientInputModel()
            {
                Id = 1,
                Name = "wwwwwww",
                LastName = "qqqq",
                Birthday = new DateTime(2001, 01, 01),
                PhoneNumber = "123123",
                Email = "@",
                StatusId = 1,
                Male = true,
            };

            yield return new Object[] { inputPatient, expectedResult };
        }
        
    }
}
