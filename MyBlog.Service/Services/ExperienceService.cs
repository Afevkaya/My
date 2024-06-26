using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.Experience;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Experience;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class ExperienceService : IExperienceService
{
    private readonly IExperienceRepository _experienceRepository;
    private readonly IMapper _mapper;


    public ExperienceService(IExperienceRepository experienceRepository, IMapper mapper)
    {
        _experienceRepository = experienceRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<List<ResponseExperience>>> GetsAsync()
    {
        var entities = await _experienceRepository.GetsAsync();
        if (entities == null)
            ApiBaseResponse<List<ResponseExperience>>.Fail(404,"Entity bulunamadı");
        
        var response = _mapper.Map<List<ResponseExperience>>(entities);
        return ApiBaseResponse<List<ResponseExperience>>.Success(200,response);
    }
    public async Task<ApiBaseResponse<ResponseExperience>> GetAsync(int id)
    {
        var entity = await _experienceRepository.GetAsync(id);
        if(entity is null)
            return ApiBaseResponse<ResponseExperience>.Fail(404, "Deneyim Bulunamadı");

        var response = _mapper.Map<ResponseExperience>(entity);
        return ApiBaseResponse<ResponseExperience>.Success(200, response);
    }
    public async Task<ApiBaseResponse<ResponseExperience>> InsertAsync(RequestInsertExperience request)
    {
        if (request is null)
            return ApiBaseResponse<ResponseExperience>.Fail(404, "Deneyim boş olamaz");

        var entity = _mapper.Map<Experience>(request);
        entity.CreatedOn = DateTime.Now;
        entity.CreatedBy = 1;
        entity.UpdatedOn = entity.CreatedOn;
        entity.UpdatedBy = entity.CreatedBy;
        await _experienceRepository.InsertAsync(entity);

        var response = _mapper.Map<ResponseExperience>(entity);
        
        return ApiBaseResponse<ResponseExperience>.Success(200, response);
    }
    public async Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(RequestUpdateExperience request)
    {
        if (request is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404, "Deneyim Boş olamaz");

        var entity = await _experienceRepository.GetAsync(request.Id);
        if(entity is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404, "Deneyim Bulunamadı");

        entity = _mapper.Map<Experience>(request);
        entity.UpdatedOn = DateTime.Now;
        entity.UpdatedBy = 1;

        await _experienceRepository.UpdateAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }

    public async Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(RequestRemoveExperience request)
    {
        var entity = await _experienceRepository.GetAsync(request.Id);
        if (entity is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404, "Entity Bulunamadı");

        await _experienceRepository.RemoveAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }
    
}
