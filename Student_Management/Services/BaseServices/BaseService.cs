using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Student_Management.Data.Context;

namespace Student_Management.Services.BaseServices
{
    // tạo lớp abstract class
    public abstract class BaseService<T, TDto> : IBaseService<T, TDto>
        where TDto : class
        where T : class
    {
        // sử dụng dependency injection thông qua constructor
        private readonly IMapper _mapper;
        private readonly ManagementContext _managementContext;

        public BaseService(IMapper mapper, ManagementContext managementContext)
        {
            _mapper = mapper;
            _managementContext = managementContext;
        }

        // async, await -> chạy bất đồng bộ -> thực hiện các cv khác nhau mà kh cần chờ các cv trc hoàn thành

        /// <summary>
        /// Phương thức Create
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T> Create(TDto model)
        {
            var modeltoCreate = _mapper.Map<TDto, T>(model);
            await _managementContext.Set<T>().AddAsync(modeltoCreate);
            await _managementContext.SaveChangesAsync();
            return modeltoCreate;
        }

        /// <summary>
        /// Phương thức Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<int> Delete(int Id)
        {
            var objId = await _managementContext.Set<T>().FindAsync(Id);
            if (objId == null)
                throw new Exception($"cannot find student with {Id}");
            _managementContext.Set<T>().Remove(objId);
            return await _managementContext.SaveChangesAsync();
        }

        /// <summary>
        /// Phương thức Get By Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<TDto> GetById(int Id)
        {
            var objId = await _managementContext.Set<T>().FindAsync(Id);
            if (objId == null)
                throw new Exception($"cannot find student with {Id}");
            var modelToGetById = _mapper.Map<T,TDto>(objId);
            return modelToGetById;
        }

        /// <summary>
        /// Phương thức Update
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<T> Update(int Id, TDto model)
        {
            var objId = await _managementContext.Set<T>().FindAsync(Id);
            if (objId == null)
                throw new Exception($"cannot find an object with {Id}");
            var modelToUpdate = _mapper.Map<TDto,T>(model, objId);
            return modelToUpdate;
        }
    }
}
