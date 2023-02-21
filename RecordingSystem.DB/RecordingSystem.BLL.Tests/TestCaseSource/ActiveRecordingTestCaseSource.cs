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
    public static class ActiveRecordingTestCaseSource
    {
        public static IEnumerable GetAllActiveRecordingsByPatientIdTestCaseSource()
        {
            List<ActiveRecordingDto> activeRecordings = new List<ActiveRecordingDto>()
            {
                new ActiveRecordingDto()
                {
                    Id = 6,
                    PatientId = 1,
                    DoctorId = 1,
                    DateTime = new DateTime(2001, 01, 01),
                    Coming = null,
                    IsDeleted = false,
                    Patient = new PatientDto()
                    {
                        Id = 1,
                        Status = new StatusDto()
                        {
                            Id = 1
                        }
                    },
                    Doctor = new DoctorDto()
                    {
                        Id = 1,
                        Specialization= new SpecializationDto()
                        {
                            Id = 1
                        },
                        Cabinet = new CabinetDto()
                        {
                            Id = 1
                        }
                    },
                    Cabinet = new CabinetDto()
                    {
                        Id = 1
                    }
                }
            };

            List<ActiveRecordingOutputModel> expectedActiveRecordings = new List<ActiveRecordingOutputModel>()
            {
                new ActiveRecordingOutputModel()
                {
                   Id = 6,
                    PatientId = 1,
                    DoctorId = 1,
                    DateTime = new DateTime(2001, 01, 01),
                    Coming = null,
                    Patient = new PatientDto()
                    {
                        Id = 1,
                        Status = new StatusDto()
                        {
                            Id = 1
                        }
                    },
                    Doctor = new DoctorDto()
                    {
                        Id = 1,
                        Specialization= new SpecializationDto()
                        {
                            Id = 1
                        },
                        Cabinet = new CabinetDto()
                        {
                            Id = 1
                        }
                    },
                    Cabinet = new CabinetDto()
                    {
                        Id = 1
                    }
                }
            };

            int id = 6;

            yield return new Object[] { id, activeRecordings, expectedActiveRecordings };

            activeRecordings = new List<ActiveRecordingDto>();
            expectedActiveRecordings = new List<ActiveRecordingOutputModel>();
            id = 6;

            yield return new Object[] { id, activeRecordings, expectedActiveRecordings };
        }

        public static IEnumerable AddActiveRecordingTestCaseSource()
        {
            ActiveRecordingInputModel inputActiveRecording = new ActiveRecordingInputModel();

            ActiveRecordingInputModel expectedResult = new ActiveRecordingInputModel();

            yield return new Object[] { inputActiveRecording, expectedResult };

            inputActiveRecording = new ActiveRecordingInputModel()
            {
                PatientId = 1,
                DoctorId = 1,
                DateTime = new DateTime(2001, 01, 01)
            };

            expectedResult = new ActiveRecordingInputModel()
            {
                PatientId = 1,
                DoctorId = 1,
                DateTime = new DateTime(2001, 01, 01)
            };

            yield return new Object[] { inputActiveRecording, expectedResult };
        }

        public static IEnumerable UpdateActiveRecordingTestCaseSource()
        {
            UpdateActiveRecordingModel updateActiveRecording = new UpdateActiveRecordingModel();

            UpdateActiveRecordingModel expectedResult = new UpdateActiveRecordingModel();

            yield return new Object[] { updateActiveRecording, expectedResult };

            updateActiveRecording = new UpdateActiveRecordingModel()
            {
                Id = 1,
                Coming = false
            };

            expectedResult = new UpdateActiveRecordingModel()
            {
                Id = 1,
                Coming = false
            };

            yield return new Object[] { updateActiveRecording, expectedResult };
        }
    }
}
