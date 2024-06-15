using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Feature;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class FeatureService : IFeatureService
{
    private readonly IFeatureRepository _featureRepository;
    private readonly IMapper _mapper;

    public FeatureService(IFeatureRepository featureRepository, IMapper mapper)
    {
        _featureRepository = featureRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<ResponseFeature>> GetAsync(int id)
    {
        var entity = await _featureRepository.GetAsync(id);
        if(entity == null)
            return ApiBaseResponse<ResponseFeature>.Fail(404,"Özellik Bulunamadı");
        
        var response = _mapper.Map<ResponseFeature>(entity);
        return ApiBaseResponse<ResponseFeature>.Success(200, response);
    }

    public async Task<ApiBaseResponse<List<ResponseFeature>>> GetsAsync()
    {
        var entities = await _featureRepository.GetsAsync();
        
        if(entities == null && entities is {Count: 0})
            return ApiBaseResponse<List<ResponseFeature>>.Fail(404,"Özellikler Bulunamadı");

        var response = _mapper.Map<List<ResponseFeature>>(entities);
        return ApiBaseResponse<List<ResponseFeature>>.Success(200,response);
    }

    public async Task<ApiBaseResponse<ResponseFeature>> InsertAsync(ResponseFeature request)
    {
        if(request == null)
            return ApiBaseResponse<ResponseFeature>.Fail(404,"İçerik boş");
        
        var entity = _mapper.Map<Feature>(request);
        entity.CreatedOn = DateTime.Now;

        await _featureRepository.InsertAsync(entity);
        return ApiBaseResponse<ResponseFeature>.Success(200);
    }

    public async Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(ResponseFeature request)
    {
        if(request is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"İçerik boş");
        
        var entity = await _featureRepository.GetAsync(request.Id);
        if(entity == null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"Entity Bulunamadı");
        
        
        await _featureRepository.RemoveAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }

    public async Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(ResponseFeature request)
    {
        if(request is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"İçerik boş");
        
        var entity = await _featureRepository.GetAsync(request.Id);
        if(entity == null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404,"Entity Bulunamadı");

        entity = _mapper.Map<Feature>(request);
        entity.UpdatedOn = DateTime.Now;
        await _featureRepository.UpdateAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }
}
