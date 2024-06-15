using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Skill;
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
}
