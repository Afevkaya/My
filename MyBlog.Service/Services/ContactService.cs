using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Contact;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;

    public ContactService(IContactRepository contactRepository, IMapper mapper)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<List<ResponseContact>>> GetsAsync()
    {
        var entities = await _contactRepository.GetsAsync();
        if(entities == null)
            return ApiBaseResponse<List<ResponseContact>>.Fail(404,"Entity bulunamadı");
        
        var response = _mapper.Map<List<ResponseContact>>(entities);
        return ApiBaseResponse<List<ResponseContact>>.Success(200, response);
    }
}
