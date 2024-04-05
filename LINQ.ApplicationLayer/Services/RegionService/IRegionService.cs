using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.RegionService
{
    public interface IRegionService
    {
        public Response<RegionEntity> Get(int RegionID);
        public Response<IList<RegionEntity>> GetAll();
        public Response<int> Insert(RegionEntity entity);
        public Response<int> Update(RegionEntity entity);
        public Response<int> Delete(int RegionID);
    }
}