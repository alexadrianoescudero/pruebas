using BP.Ecommerce.Application.DTOs;
using BP.Ecommerce.Application.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BP.Ecommerce.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService service;

        public BrandController(IBrandService service)
        {
            this.service = service;
        }
        /// <summary>
        /// Método que obtiene todas las marcas
        /// </summary>
        /// <remarks>Método que obtiene todas las marcas de los productos registradas en la base de datos</remarks>
        /// <response code="200">TODO BIEN</response>
        [HttpGet]
        public async Task<List<BrandDto>> GetAllAsync()
        {
            return await service.GetAllAsync();
        }

        /// <summary>
        /// Método que obtiene las marcas por Id
        /// </summary>
        /// <remarks>Método que obtiene las marcas de los productos por Id</remarks>
        /// <param name="id">id del producto</param>
        /// <response code="200">TODO BIEN</response>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<BrandDto> GetByIdAsync(Guid id)
        {
            return await service.GetByIdAsync(id);
        }

        /// <summary>
        /// Método que agrega un producto
        /// </summary>
        /// <remarks>Método que agrega un producto a la base de datos</remarks>
        /// <param name="createBrandDto">Nombre del producto</param>
        /// <response code="200">TODO BIEN</response>
        /// <returns></returns>
        [HttpPost]
        public async Task<BrandDto> PostAsync(CreateBrandDto createBrandDto)
        {
            return await service.PostAsync(createBrandDto);
        }


        /// <summary>
        /// Método que actualiza un producto
        /// </summary>
        /// <remarks>Método que actualiza un producto en la base de datos</remarks>
        /// <param name="brandDto">Nombre actualizado</param>
        /// <response code="200">TODO BIEN</response>
        /// <returns></returns>
        [HttpPut]
        public async Task<BrandDto> PutAsync(BrandDto brandDto)
        {
            return await service.PutAsync(brandDto);
        }


        /// <summary>
        /// Método que elimina un producto
        /// </summary>
        /// <remarks>Método que elimina un producto en la base de datos</remarks>
        /// <param name="id">id del producto</param>
        /// <response code="200">TODO BIEN</response>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await service.DeleteAsync(id);
        }

    }
}
