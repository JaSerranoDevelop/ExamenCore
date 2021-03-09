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
            CreateMap<StudentDTO, Student>()
                .ForMember(a => a.StudenAssigments, map => map.Ignore());


            CreateMap<Assignments, AssigmentDTO>();
            CreateMap<AssigmentDTO, Assignments>() 
                .ForMember(a => a.StudenAssigments, map => map.Ignore());


            CreateMap<StudenAssigments, StudentAssigmentDTO>();
            CreateMap<StudentAssigmentDTO, StudenAssigments>() 
                .ForMember(a => a.Assignments, map => map.Ignore())
                .ForMember(a => a.Student, map => map.Ignore());

            CreateMap<StudenAssigments, StudenAssigmenDetailDTO>()
                .ForMember(a => a.AssigmentName, map => map.MapFrom(s => s.Assignments.Name))
                .ForMember(a => a.StudentName, map => map.MapFrom(s => s.Student.Name));
                
        }
    }
}
