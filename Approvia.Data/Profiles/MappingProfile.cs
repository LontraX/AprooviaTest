using AutoMapper;
using Approvia.Data.DTOs;
using Approvia.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvia.Data.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<MySparkPlugFeedback, AddFormDTO>().ReverseMap();
        }
    }
}
