using AutoMapper;
using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.Portfolio;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Portfolio;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;

namespace MyBlog.Services;

public class PortfolioService : IPortfolioService
{
    private readonly IPortfolioRepository _portfolioRepository;
    private readonly IMapper _mapper;

    public PortfolioService(IPortfolioRepository portfolioRepository, IMapper mapper)
    {
        _portfolioRepository = portfolioRepository;
        _mapper = mapper;
    }

    public async Task<ApiBaseResponse<List<ResponsePortfolio>>> GetsAsync()
    {
        var entities = await _portfolioRepository.GetsAsync();
        if (entities == null)
            return ApiBaseResponse<List<ResponsePortfolio>>.Fail(404,"Entity bulunamadı");

        var response = _mapper.Map<List<ResponsePortfolio>>(entities);
        return ApiBaseResponse<List<ResponsePortfolio>>.Success(200,response);
    }

    public async Task<ApiBaseResponse<ResponsePortfolio>> InsertAsync(RequestInsertPortfolio request)
    {
        if (request is null)
            return ApiBaseResponse<ResponsePortfolio>.Fail(400, "İçerik boş olamaz");

        var entity = _mapper.Map<Portfolio>(request);
        entity.CreatedOn = DateTime.Now;
        entity.CreatedBy = 1;
        entity.UpdatedOn = entity.CreatedOn;
        entity.UpdatedBy = entity.CreatedBy;
        await _portfolioRepository.InsertAsync(entity);

        var response = _mapper.Map<ResponsePortfolio>(entity);
        return ApiBaseResponse<ResponsePortfolio>.Success(200);
    }
}
