using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Models;
using WebService.Models.DTOs;

namespace WebService.Config
{
    public static class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Student, StudentDTO>().ReverseMap();
            });
        }
    }
}