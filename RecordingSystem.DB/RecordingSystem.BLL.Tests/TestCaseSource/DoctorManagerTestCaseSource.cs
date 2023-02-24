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
                    Specialization = new SpecializationOutputModel()
                    {
                        Id = 1,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetOutputModel()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    }
                }
            };

            yield return new Object[] { doctors, expected };
        }

        public static IEnumerable GetAllDoctorBySpecializationIdTestCaseSource()
        {
            List<DoctorDto> doctors = new List<DoctorDto>()
            {
                new DoctorDto()
                {
                    Id = 1,
                    Name = "Andrey",
                    LastName = "Strelnikov",
                    Male = true,
                    IsDeleted = false,
                    Birthday = new DateTime(2001, 05, 20),
                    Specialization = new SpecializationDto()
                    {
                        Id = 3,
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
                    Specialization = new SpecializationOutputModel()
                    {
                        Id = 3,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetOutputModel()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    }
                }
            };

            int SpecializationId = 3;

            yield return new Object[] { doctors, expected , SpecializationId };
        }

        public static IEnumerable GetAllDoctorsByServiceIdTestCaseSource()
        {
            List<DoctorDto> doctors = new List<DoctorDto>()
            {
                new DoctorDto()
                {
                    Id = 1,
                    Name = "Andrey",
                    LastName = "Strelnikov",
                    Male = true,
                    IsDeleted = false,
                    Birthday = new DateTime(2001, 05, 20),
                    Specialization = new SpecializationDto()
                    {
                        Id = 3,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetDto()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    },
                    Services=new List<ServiceDto>
                    {
                        new ServiceDto()
                        {
                            Id = 2,
                            Name = "massage"
                        }
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
                    Specialization = new SpecializationOutputModel()
                    {
                        Id = 3,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetOutputModel()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    },
                    Services=new List<ServiceOutputModel>
                    {
                        new ServiceOutputModel()
                        {
                            Id = 2,
                            Name = "massage"
                        }
                    }
                }
            };

            int ServiceId = 2;

            yield return new Object[] { doctors, expected, ServiceId };
        }

        public static IEnumerable GetAllFreeDoctorsByDayOfWeekIdTestCaseSource()
        {
            List<DoctorDto> doctors = new List<DoctorDto>()
            {
                new DoctorDto()
                {
                    Id = 1,
                    Name = "Andrey",
                    LastName = "Strelnikov",
                    Male = true,
                    IsDeleted = false,
                    Birthday = new DateTime(2001, 05, 20),
                    Specialization = new SpecializationDto()
                    {
                        Id = 3,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetDto()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    },
                    Services=new List<ServiceDto>
                    {
                        new ServiceDto()
                        {
                            Id = 2,
                            Name = "massage"
                        }
                    },
                    TimeRecording = new List<TimeRecordingDto>
                    {
                        new TimeRecordingDto()
                        {   Id = 1,
                            Date= new DateTime(2023,02,21),
                            TimeTable = new TimeTableDto
                            {
                                Id=1,
                                DayOfWeek = new DayOfWeekDto() 
                                {
                                    Id = 2,
                                    Name = "Monday"
                                }
                            },
                            Occupied = false
                        }
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
                    Specialization = new SpecializationOutputModel()
                    {
                        Id = 3,
                        Name = "doctor"
                    },
                    Cabinet = new CabinetOutputModel()
                    {
                        Id = 1,
                        Number = 101,
                        Status = null
                    },
                    Services=new List<ServiceOutputModel>
                    {
                        new ServiceOutputModel()
                        {
                            Id = 2,
                            Name = "massage"
                        }
                    },
                    TimeRecording = new List<TimeRecordingOutputModel>
                    {
                        new TimeRecordingOutputModel()
                        {   Id = 1,
                            Date= new DateTime(2023,02,21),
                            TimeTable = new TimeTableOutputModel
                            {
                                Id=1,
                                DayOfWeek = new DayOfWeekOutputModel()
                                {
                                    Id = 2,
                                    Name = "Monday"
                                }
                            },
                            Occupied = false
                        }
                    }
                }
            };

            int DayOfWeekId = 2;

            yield return new Object[] { doctors, expected, DayOfWeekId };
        }

        public static IEnumerable AddDoctorTestCaseSource()
        {

            DoctorInputModel inputDoctor = new DoctorInputModel()
            {
                Id = 1,
                Name = "Andrey",
                LastName = "Strelnikov",
                Male = true,
                Birthday = new DateTime(2001, 05, 20),
            };
            DoctorInputModel expected = new DoctorInputModel()
            {
                Id = 1,
                Name = "Andrey",
                LastName = "Strelnikov",
                Male = true,
                Birthday = new DateTime(2001, 05, 20),
            };

            yield return new Object[] { inputDoctor, expected };
        }

        public static IEnumerable UpdateDoctorTestCaseSource()
        {

            DoctorInputModel inputDoctor = new DoctorInputModel()
            {
                Id = 1,
                Name = "Andrey",
                LastName = "Strelnikov",
                Male = true,
                Birthday = new DateTime(2001, 05, 20),
            };
            DoctorInputModel expected = new DoctorInputModel()
            {
                Id = 1,
                Name = "Andrey",
                LastName = "Strelnikov",
                Male = true,
                Birthday = new DateTime(2001, 05, 20),
            };

            yield return new Object[] { inputDoctor, expected };
        }
        
    }

}
