using AutoMapper;
using MyBlog.Core.DTOs.Request;
using MyBlog.Core.DTOs.Request.About;
using MyBlog.Core.DTOs.Response.About;
using MyBlog.Core.DTOs.Response.Contact;
using MyBlog.Core.DTOs.Response.Experience;
using MyBlog.Core.DTOs.Response.Feature;
using MyBlog.Core.DTOs.Response.Message;
using MyBlog.Core.DTOs.Response.Portfolio;
using MyBlog.Core.DTOs.Response.Service;
using MyBlog.Core.DTOs.Response.Skill;
using MyBlog.Core.DTOs.Response.Testimonial;
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

        CreateMap<Skill, ResponseSkill>().ReverseMap();
        CreateMap<RequestInsertService, Skill>().ReverseMap();

        CreateMap<Portfolio, ResponsePortfolio>().ReverseMap();

        CreateMap<Experience, ResponseExperience>().ReverseMap();

        CreateMap<Testimonial, ResponseTestimonial>().ReverseMap();

        CreateMap<Contact, ResponseContact>().ReverseMap();

        CreateMap<Message, ResponseMessage>().ReverseMap();
        CreateMap<RequestInsertMessage, Message>().ReverseMap();
    }
}
