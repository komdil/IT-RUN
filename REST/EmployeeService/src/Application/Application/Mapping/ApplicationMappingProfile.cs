using AutoMapper;
using Employee.Web.Api.Contacts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<Domain.Employee, GetEmployeesResponse>()
                .ForMember(s => s.City, op => op.MapFrom(s => s.Contact.City));
        }
    }
}
