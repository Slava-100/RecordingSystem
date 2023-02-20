﻿using RecordingSystem.DAL.Models;
namespace RecordingSystem.BLL.Models
{
    public class ServiceOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Price { get; set; }
        public int? SpecializationId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Male { get; set; }
        public SpecializationDto Specialization { get; set; }
    }
}
