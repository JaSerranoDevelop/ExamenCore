using AutoMapper;
using BPT.Test.JASM.BackEnd.DataAccess;
using BPT.Test.JASM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPT.Test.JASM
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentDTO>();
            CreateMap<Assignments, AssigmentDTO>();
        }
    }
}
