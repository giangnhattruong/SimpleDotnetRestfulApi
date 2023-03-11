using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Domain.Services;
using SimpleRestfulApi.Resources;

namespace SimpleRestfulApi.Controllers
{
    [Route("/api/v1.0/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResource>> ListAsync()
        {
            var products = await _productService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);
            return resources;
        }
    }
}
