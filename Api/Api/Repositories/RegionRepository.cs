using Api.Data;
using Api.Models.Domain;

namespace Api.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly SqlContext sqlContext;

        public RegionRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return sqlContext.Regions.ToList();
        }
    }
}