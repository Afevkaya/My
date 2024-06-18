using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.Skill;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Skill;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class SkillService : ISkillService
{
    private readonly ISkillRepository _skillRepository;
    private readonly IMapper _mapper;

    public SkillService(ISkillRepository skillRepository, IMapper mapper)
    {
        _skillRepository = skillRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<List<ResponseSkill>>> GetsAsync()
    {
        var entities = await _skillRepository.GetsAsync();
        if(entities == null)
            return ApiBaseResponse<List<ResponseSkill>>.Fail(404,"Entity Bulunamadı");

        var response = _mapper.Map<List<ResponseSkill>>(entities);
        return ApiBaseResponse<List<ResponseSkill>>.Success(200,response);
    }

    public async Task<ApiBaseResponse<ResponseSkill>> GetAsync(int Id)
    {
        var entity = await _skillRepository.GetAsync(Id);
        if (entity is null)
            return ApiBaseResponse<ResponseSkill>.Fail(404, "Yetenek Bulunamadı");

        var response = _mapper.Map<ResponseSkill>(entity);
        return ApiBaseResponse<ResponseSkill>.Success(200, response);
    }

    public async Task<ApiBaseResponse<ResponseSkill>> InsertAsync(RequestInsertSkill request)
    {
        if (request is null)
            return ApiBaseResponse<ResponseSkill>.Fail(404, "Yetenek alanları boş olamaz");

        var entity = _mapper.Map<Skill>(request);
        if(entity is null)
            return ApiBaseResponse<ResponseSkill>.Fail(500, "Sistemsel bir hata oluştu");
        entity.CreatedOn = DateTime.Now;
        entity.CreatedBy = 1;
        entity.UpdatedOn = entity.CreatedOn;
        entity.UpdatedBy = entity.CreatedBy;

        await _skillRepository.InsertAsync(entity);
        var response = _mapper.Map<ResponseSkill>(entity);
        return ApiBaseResponse<ResponseSkill>.Success(200, response);
    }

    public async Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(RequestUpdateSkill request)
    {
        if (request is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404, "Model Boş");
        
        var entity = await _skillRepository.GetAsync(request.Id);
        if(entity is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404, "Yetenek Bulunamadı");

        entity = _mapper.Map<Skill>(request);
        entity.UpdatedOn = DateTime.Now;
        entity.UpdatedBy = 1;
        await _skillRepository.UpdateAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }
    
    public async Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(RequestRemoveSkill request)
    {
        var entity = await _skillRepository.GetAsync(request.Id);
        if (entity is null)
            return ApiBaseResponse<ResponseNoContent>.Fail(404, "Entity Bulunamadı");

        await _skillRepository.RemoveAsync(entity);
        return ApiBaseResponse<ResponseNoContent>.Success(200);
    }
}
