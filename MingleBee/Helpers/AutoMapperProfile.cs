using AutoMapper;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using MingleBee.Dtos;
using MingleBee.Models;
using System.Linq;

namespace MingleBee.Helpers
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
            src.Photos.FirstOrDefault(p => p.IsMain).Url))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
             src.Photos.FirstOrDefault(p => p.IsMain).Url))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));


            CreateMap<Photo, PhotosForDetailedDto>();
        }
    }
}
