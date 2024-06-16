using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Experience;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class ExperienceService : IExperinceService
{
    private readonly IExperinceRepository _experinceRepository;
    private readonly IMapper _mapper;

    public ExperienceService(IExperinceRepository experinceRepository, IMapper mapper)
    {
        _experinceRepository = experinceRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<List<ResponseExperience>>> GetsAsync()
    {
        var entities = await _experinceRepository.GetsAsync();
        if (entities == null)
            ApiBaseResponse<List<ResponseExperience>>.Fail(404,"Entity bulunamadı");
        
        var response = _mapper.Map<List<ResponseExperience>>(entities);
        return ApiBaseResponse<List<ResponseExperience>>.Success(200,response);
    }
}
