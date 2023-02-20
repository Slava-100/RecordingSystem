using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Tests.TestCaseSource
{
    public static class DoctorManagerTestCaseSource
    {
        public static IEnumerable GetAllDoctorsTestCaseSource()
        {
            List<DoctorDto> doctors = new List<DoctorDto>()
            {
                new DoctorDto()
                {
                    Id = 1,
                    Name = "Andrey",
                    LastName = "Strelnikov",
                    Male = true,
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
            

            List<DoctorOutputModel> expected = new List<DoctorOutputModel>()
            {
                new DoctorOutputModel()
                {
                    Id = 1,
                    Name = "Andrey",
                    LastName = "Strelnikov",
                    Male = true,
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

            yield return new Object[] { doctors, expected };
        }
    }
}
