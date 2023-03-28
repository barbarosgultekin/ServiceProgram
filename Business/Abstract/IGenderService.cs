using Business.Models.BaseDTO;
using Business.Models.BaseListDto;
using Business.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenderService : IServiceRepository<GenderDto>
    {
        Task<List<GendersDto>> GetAllAsync();
    }
}
