using Api.Models.Domain;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("region")]
    public class RegionController : Controller
    {
        private readonly IRegionRepository regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        public IActionResult GetAllRegion()
        {
            // var regions = new List<Region>()
            // {
            //     new Region
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Wellington",
            //         Code = "WLG",
            //         Area = 227755,
            //         Lat = -1.2442,
            //         Long = 200.55,
            //         Population = 500000
            //     },
            //     new Region
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Auckland",
            //         Code = "AUCK",
            //         Area = 332211,
            //         Lat = -1.2231,
            //         Long = 200.44,
            //         Population = 500000
            //     }
            // };
            var regions = regionRepository.GetAll();
            return Ok(regions);
        }
    }
}
