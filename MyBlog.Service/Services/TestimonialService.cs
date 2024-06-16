using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Testimonial;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class TestimonialService : ITestimonialService
{
    private readonly ITestimonialRepository _testimonialRepository;
    private readonly IMapper _mapper;

    public TestimonialService(ITestimonialRepository testimonialRepository, IMapper mapper)
    {
        _testimonialRepository = testimonialRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<List<ResponseTestimonial>>> GetsAsync()
    {
        var entities = await _testimonialRepository.GetsAsync();
        if(entities == null)
            return ApiBaseResponse<List<ResponseTestimonial>>.Fail(404,"Entity bulunamadı");

        var response = _mapper.Map<List<ResponseTestimonial>>(entities);
        return ApiBaseResponse<List<ResponseTestimonial>>.Success(200, response);
    }
}
