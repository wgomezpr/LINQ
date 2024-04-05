using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;

namespace LINQ.ApplicationLayer.Services.TerritoryServices
{
    public interface ITerritoryServices
    {
        public Response<TerritoryEntity> Get(int TerritoryID);
        public Response<IList<TerritoryEntity>> GetAll();
        public Response<int> Insert(TerritoryEntity entity);
        public Response<int> Update(TerritoryEntity entity);
        public Response<int> Delete(int TerritoryID);
    }
}