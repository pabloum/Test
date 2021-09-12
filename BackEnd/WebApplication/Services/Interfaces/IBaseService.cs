using Entities.DTOs;
using Entities.Entities;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IBaseService<T>  where T : BaseEntity
    {
        IEnumerable<BaseDTO> GetAll();
        IEnumerable<BaseDTO> Filter(string filter);
        BaseDTO Create(BaseDTO entity);
    }
}
