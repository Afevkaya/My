using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.About;
using MyBlog.Core.DTOs.Response.About;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class AboutService : IAboutService
{
    private readonly IAboutRepository _aboutRepository;
    private readonly IMapper _mapper;

    public AboutService(IAboutRepository aboutRepository, IMapper mapper)
    {
        _aboutRepository = aboutRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<ResponseAbout>> GetAsync(int id)
    {
        ApiBaseResponse<ResponseAbout> response = new();
        return response;
    }

    public async Task<ApiBaseResponse<List<ResponseAbout>>> GetsAsync()
    {
        ApiBaseResponse<List<ResponseAbout>> response = new();
        return response;
    }

    public async Task<ApiBaseResponse<ResponseAbout>> InsertAsync(RequestInsertAbout request)
    {
        ApiBaseResponse<ResponseAbout> response = new();
        var entity = _mapper.Map<About>(request);
        await _aboutRepository.InsertAsync(entity);
        response.Data = _mapper.Map<ResponseAbout>(entity);
        return response;
    }

    public Task RemoveAsync(ResponseAbout entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ResponseAbout entity)
    {
        throw new NotImplementedException();
    }
}
