using System;
using AutoMapper;
using DTOLayer.DTOs.InstructorDTOs;
using EntityLayer.Concrete;

namespace AspenTeachesCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<InstructorAddDTO, Instructor>();
            CreateMap<Instructor, InstructorAddDTO>();
        }
    }
}
