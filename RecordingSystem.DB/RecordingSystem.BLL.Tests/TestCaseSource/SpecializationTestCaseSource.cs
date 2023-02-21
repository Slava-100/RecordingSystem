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
    public static class SpecializationTestCaseSource
    {
        public static IEnumerable GetAllSpecializationsTestCaseSource()
        {
            List<SpecializationDto> specializations = new List<SpecializationDto>()
            {
                new SpecializationDto()
                {
                    Id = 1,
                    Name= "Shaurmist"
                }
            };

            List<SpecializationOutputModel> expectedSpecializations = new List<SpecializationOutputModel>()
            {
                new SpecializationOutputModel()
                {
                    Id = 1,
                    Name= "Shaurmist"
                }
            };

            yield return new Object[] { specializations, expectedSpecializations };

            specializations = new List<SpecializationDto>();
            expectedSpecializations = new List<SpecializationOutputModel>();

            yield return new Object[] { specializations, expectedSpecializations };
        }

        public static IEnumerable AddSpecializationTestCaseSource()
        {
            SpecializationInputModel inputSpecialization = new SpecializationInputModel();

            SpecializationInputModel expectedResult = new SpecializationInputModel();

            yield return new Object[] { inputSpecialization, expectedResult };

            inputSpecialization = new SpecializationInputModel()
            {
                Name = "Shaurmist"
            };

            expectedResult = new SpecializationInputModel()
            {
                Name = "Shaurmist"
            };

            yield return new Object[] { inputSpecialization, expectedResult };
        }
    }
}
