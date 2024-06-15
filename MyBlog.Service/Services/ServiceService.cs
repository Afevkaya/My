using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Service;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class ServiceService : IServiceService
{
    private readonly IServiceRepository _serviceRepository;
    private readonly IMapper _mapper;

    public ServiceService(IServiceRepository serviceRepository, IMapper mapper)
    {
        _serviceRepository = serviceRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<ResponseService>> GetAsync(int id)
    {
        var entity = _serviceRepository.GetAsync(id);
        if (entity == null)
            return ApiBaseResponse<ResponseService>.Fail(404, "Entity Bulunamadı");
        
        var response = _mapper.Map<ResponseService>(entity);
        return ApiBaseResponse<ResponseService>.Success(200,response);

    }

    public async Task<ApiBaseResponse<List<ResponseService>>> GetsAsync()
    {
        var entites = await _serviceRepository.GetsAsync();
        if (entites == null)
            return ApiBaseResponse<List<ResponseService>>.Fail(404, "Entity Bulunamadı");

        var response = _mapper.Map<List<ResponseService>>(entites);
        return ApiBaseResponse<List<ResponseService>>.Success(200, response);
    }

    // public Task<ApiBaseResponse<ResponseService>> InsertAsync(RequestInsertService request)
    // {
    //     throw new NotImplementedException();
    // }

    // public Task<ResponseNoContent> RemoveAsync(ResponseService entity)
    // {
    //     throw new NotImplementedException();
    // }

    // public Task<ResponseNoContent> UpdateAsync(ResponseService entity)
    // {
    //     throw new NotImplementedException();
    // }
}
