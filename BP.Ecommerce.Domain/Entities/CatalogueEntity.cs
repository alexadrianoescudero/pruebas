using System.ComponentModel.DataAnnotations;

namespace BP.Ecommerce.Domain.Entities
{
    public class CatalogueEntity : AuditoryEntity
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Este es el nombre de la marca
        /// </summary>
        public string Name { get; set; }
    }
}
