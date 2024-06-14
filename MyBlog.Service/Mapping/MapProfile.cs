using AutoMapper;
using MyBlog.Core.DTOs.Request.About;
using MyBlog.Core.DTOs.Response.About;
using MyBlog.Core.Entities;

namespace MyBlog.Services;

public class MapProfile: Profile
{
    public MapProfile()
    {
        CreateMap<About,ResponseAbout>().ReverseMap();
        CreateMap<RequestInsertAbout, About>();
    }
}
