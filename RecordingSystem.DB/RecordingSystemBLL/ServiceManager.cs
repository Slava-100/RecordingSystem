using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL
{
    public class ServiceManager
    {
        Mapperrr _mapperrr = new Mapperrr();
        public List<ServiceOutputModel> GetAllProducts()
        {
            ServiceRepository repository = new ServiceRepository();
            var products = repository.AddService();

            var result = _mapperrr.MapServiceDtoToProductOutputModel(products);

            return result;
        }
    }
}
