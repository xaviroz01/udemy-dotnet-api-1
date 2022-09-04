using Api.Models.Domain;

namespace Api.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}