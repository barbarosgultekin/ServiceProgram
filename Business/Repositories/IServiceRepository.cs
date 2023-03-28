using Core.Signatures;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public interface IServiceRepository<TDto>
    where TDto : class, IBaseDto, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TDto> Get(int id);

       // Task<TDto> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<int> Insert(TDto dto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// 
        Task Update(int id, TDto dto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task RemoveCacheAsync();


    }
}