using AutoMapper;
using Azure;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request;
using MyBlog.Core.DTOs.Response.Message;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class MessageService : IMessageService
{
    private readonly IMessageRepository _messageRepository;
    private readonly IMapper _mapper;

    public MessageService(IMessageRepository messageRepository, IMapper mapper)
    {
        _messageRepository = messageRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<ResponseMessage>> InsertAsync(RequestInsertMessage request)
    {
        if(request == null)
            return ApiBaseResponse<ResponseMessage>.Fail(404,"Request boş");
        
        var entity = _mapper.Map<Message>(request);
        entity.CreatedOn = DateTime.Now;
        entity.CreatedBy = 1;
        entity.UpdatedOn = entity.CreatedOn;
        entity.UpdatedBy = entity.CreatedBy;
        entity.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        entity.Status = true;
        await _messageRepository.InsertAsync(entity);

        var response = _mapper.Map<ResponseMessage>(entity);
        return ApiBaseResponse<ResponseMessage>.Success(200, response);
    }
}
