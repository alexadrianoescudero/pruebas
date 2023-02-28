using BP.Ecommerce.Application.DTOs;

namespace BP.Ecommerce.Application.ServicesInterfaces
{
    public interface IBrandService
    {
        /// <summary>
        /// Obtiene todas las marcas
        /// </summary>
        public Task<List<BrandDto>> GetAllAsync();
        /// <summary>
        /// Obtiene marca por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<BrandDto> GetByIdAsync(Guid id);
        /// <summary>
        /// Agrega nueva marca
        /// </summary>
        /// <param name="createBrandDto"></param>
        /// <returns></returns>
        public Task<BrandDto> PostAsync(CreateBrandDto createBrandDto);
        /// <summary>
        /// Actualiza marca
        /// </summary>
        /// <param name="brandDto"></param>
        /// <returns></returns>
        public Task<BrandDto> PutAsync(BrandDto brandDto);
        /// <summary>
        /// Elimina marca por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> DeleteAsync(Guid id);
    }
}
