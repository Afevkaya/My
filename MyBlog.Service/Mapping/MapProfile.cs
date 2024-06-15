using AutoMapper;
using MyBlog.Core.DTOs.Request.About;
using MyBlog.Core.DTOs.Response.About;
using MyBlog.Core.DTOs.Response.Feature;
using MyBlog.Core.DTOs.Response.Service;
using MyBlog.Core.Entities;

namespace MyBlog.Services;

public class MapProfile: Profile
{
    public MapProfile()
    {
        CreateMap<About,ResponseAbout>().ReverseMap();
        CreateMap<RequestInsertAbout, About>();

        CreateMap<Feature, ResponseFeature>().ReverseMap();

        CreateMap<Service, ResponseService>().ReverseMap();
    }
}
