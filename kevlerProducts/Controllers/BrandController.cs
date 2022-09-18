using AutoMapper;
using DataAccessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel.BrandViewModel;

namespace kevlerProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService, IMapper mapper)
        {
            _brandService = brandService;
            _mapper = mapper;
        }

        [HttpGet("BrandList")]
        public async Task<IActionResult> GetBrandList()  
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var listBrand = await _brandService.Get();

            var brandDto = _mapper.Map<List<BrandDto>>(listBrand);

            return Ok(brandDto);
        }
    }
}
