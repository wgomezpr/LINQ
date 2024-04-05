using LINQ.DomainLayer.DTO.Entities;
using LINQ.DomainLayer.DTO.Responses;
using LINQ.DomainLayer.Interfaces;

namespace LINQ.ApplicationLayer.Services.TerritoryServices
{
    public class TerritoryServices : ITerritoryServices
    {
        // Instantiate the interface
        private readonly ITerritory _repository;

        public TerritoryServices(ITerritory repository)
        {
            _repository = repository;
        }

        public Response<TerritoryEntity> Get(int TerritoryID)
        {
            var obj = _repository.Get(TerritoryID);
            return new Response<TerritoryEntity>(true, obj, "OK");
        }

        public Response<IList<TerritoryEntity>> GetAll()
        {
            var obj = _repository.GetAll();
            return new Response<IList<TerritoryEntity>>(true, obj, "OK");
        }

        public Response<int> Insert(TerritoryEntity entity)
        {
            var output = _repository.Insert(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Update(TerritoryEntity entity)
        {
            var output = _repository.Update(entity);
            return new Response<int>(true, output, "OK");
        }

        public Response<int> Delete(int TerritoryID)
        {
            var output = _repository.Delete(TerritoryID);
            return new Response<int>(true, output, "OK");
        }
    }
}