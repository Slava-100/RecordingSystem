﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class DoctorOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool? Male { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public SpecializationDto Specialization { get; set; }
        public CabinetDto Cabinet { get; set; }
        public List<ServiceDto> Services { get; set; } = new List<ServiceDto>();
    }
}
