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
    public class ServiceManagerTestCaseSource
    {
        public static IEnumerable GetAllServiceByMaleTestCaseSource()
        {
            List<ServiceDto> services = new List<ServiceDto>()
            {
                new ServiceDto()
                {
                    Id = 1,
                    Name = "massage",
                    Price = 234,
                    SpecializationId = 1,
                    IsDeleted = false,
                    Male = false,
                    Specialization = new SpecializationDto()
                    {
                        Id = 1,
                        Name = "massage therapist"
                    },
                }
            };

            List<ServiceOutputModel> expected = new List<ServiceOutputModel>()
            {
                new ServiceOutputModel()
                {
                    Id = 1,
                    Name = "massage",
                    Price = 234,
                    SpecializationId = 1,
                    IsDeleted = false,
                    Male = false,
                    Specialization = new SpecializationDto()
                    {
                        Id = 1,
                        Name = "massage therapist"
                    },
                }
            };
            bool male = false; 
            yield return new Object[] { services, expected, male };
        }
    }
}
