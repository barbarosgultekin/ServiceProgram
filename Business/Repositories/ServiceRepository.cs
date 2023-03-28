using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Aspects.CacheAspect;
using Core.Signatures;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Repositories
{
    public class ServiceRepository<TEntity, TDto> : IServiceRepository<TDto>
        where TEntity : class, IBaseEntity, new()
        where TDto : class, IBaseDto, new()
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public ServiceRepository(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [CacheAspect]
        public virtual async Task<TDto> Get(int id)
        {
            var entity = await _repository.Get(id);
            return _mapper.Map<TDto>(entity);
        }
        [RemoveCacheAspect]
        public virtual async Task<int> Insert(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.Insert(entity);
            return entity.Id;
        }
        [RemoveCacheAspect]
        public virtual async Task Update(int id, TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.Id = id;
            await _repository.Update(entity);
        }
        [RemoveCacheAspect]
        public virtual async Task Delete(int id)
        {
            var entity = await _repository.Get(id);
            await _repository.Delete(entity);
        }

        public virtual async Task RemoveCacheAsync()
        {
            await Task.CompletedTask.ConfigureAwait(false);
        }        
    }
}