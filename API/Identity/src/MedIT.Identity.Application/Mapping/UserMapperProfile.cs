using AutoMapper;
using MedIT.Identity.Application.Commands.Register;
using MedIT.Identity.Domain.Entities;

namespace MedIT.Identity.Application.Mapping;

public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<RegisterCommand, User>();
    }
}