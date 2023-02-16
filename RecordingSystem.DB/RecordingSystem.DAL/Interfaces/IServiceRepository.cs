﻿using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface IServiceRepository
    {
        public void AddService(ServiceDto serviceDto);
        public void UpdateServiceById(ServiceDto service);
        public void UpdateIsDeletedServiceById(ServiceDto service);
        public List<ServiceDto> GetAllServicesByDoctorId(int id);
        public List<ServiceDto> GetAllServiceByMale(bool? male);
    }
}