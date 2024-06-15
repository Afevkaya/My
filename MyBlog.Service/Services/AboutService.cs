using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.About;
using MyBlog.Core.DTOs.Response;
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
        var entity = await _aboutRepository.GetAsync(id);
        if (entity == null)
            return ApiBaseResponse<ResponseAbout>.Fail(404,"Entity Bulunamadı");
        
        var response = _mapper.Map<ResponseAbout>(entity);
        return ApiBaseResponse<ResponseAbout>.Success(200, response);
    }

    public async Task<ApiBaseResponse<List<ResponseAbout>>> GetsAsync()
    {
        var entites = await _aboutRepository.GetsAsync();
        if(entites == null)
            return ApiBaseResponse<List<ResponseAbout>>.Fail(404,"Entity Bulunamadı");
        
        var response = _mapper.Map<List<ResponseAbout>>(entites);

        return ApiBaseResponse<List<ResponseAbout>>.Success(200,response);
    }

    public async Task<ApiBaseResponse<ResponseAbout>> InsertAsync(RequestInsertAbout request)
    {
        ApiBaseResponse<ResponseAbout> response = new();
        var entity = _mapper.Map<About>(request);
        await _aboutRepository.InsertAsync(entity);
        response.Data = _mapper.Map<ResponseAbout>(entity);
        return response;
    }

    public async Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(ResponseAbout request)
    {
        if(request == null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"İçerik Boş");
        
        var entity = await _aboutRepository.GetAsync(request.Id);
        if(entity == null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"Entity Bulunamadı");
        
        await _aboutRepository.RemoveAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }

    public async Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(ResponseAbout request)
    {
        if(request == null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"İçerik Boş");
        
        var entity = await _aboutRepository.GetAsync(request.Id);
        if(entity == null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"Entity Bulunamadı");

        entity = _mapper.Map<About>(request);
        entity.UpdatedOn = DateTime.Now;

        await _aboutRepository.UpdateAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }
}
