using AutoMapper;
using AutoMapperMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BeerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add(BeerRequest request)
        {
            Beer beer= _mapper.Map<Beer>(request);
            return Ok(beer);
        }
    }
}
