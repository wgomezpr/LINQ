using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.RegionService
{
    public class RegionService : IRegionService
    {
        // Instantiate the interface
        private readonly IRegion _repository;

        public RegionService(IRegion repository)
        {
            _repository = repository;
        }

        public Response<RegionEntity> Get(int RegionID)
        {
            var obj = _repository.Get(RegionID);
            return new Response<RegionEntity>(true, obj, "OK");
        }

        public Response<IList<RegionEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<RegionEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(RegionEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(RegionEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int RegionID)
        {
            var output = _repository.Delete(RegionID);
            return new Response<int>(true, output, "OK");
        }
    }
}