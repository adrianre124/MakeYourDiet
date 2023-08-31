using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MakeYourDiet.DTOs;
using MakeYourDiet.Models;

namespace MakeYourDiet.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterDto, User>();
        }
    }
}