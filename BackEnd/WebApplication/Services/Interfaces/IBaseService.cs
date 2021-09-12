using Entities.DTOs;
using Entities.Entities;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IBaseService<T, DTO>  where T : BaseEntity where DTO : BaseDTO
    {
        IEnumerable<DTO> GetAll();
        IEnumerable<DTO> Filter(string filter);
        IEnumerable<DTO> Create(DTO entity);
    }
}
