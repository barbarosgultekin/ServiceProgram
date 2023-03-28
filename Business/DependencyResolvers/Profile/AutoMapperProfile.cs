using AutoMapper;
using Business.Models.BaseDTO;
using Business.Models.BaseListDto;
using Business.Models.BaseListDTO;
using DataAccess.Entities;

namespace Business.DependencyResolvers.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Gender, GendersDto>();
            CreateMap<Gender, GenderDto>().ReverseMap();

            CreateMap<Customer, CustomersDto>();
            CreateMap<Customer, CustomerDto>().ReverseMap();

            CreateMap<Product, ProductsDto>();
            CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<ServiceForm, ServiceFormsDto>();
            CreateMap<ServiceForm, ServiceFormDto>().ReverseMap();

            CreateMap<BranchOffice, BranchOfficesDto>();               
            CreateMap<BranchOffice, BranchOfficeDto>().ReverseMap();

            CreateMap<SparePartList, SparePartsListDto>();
            CreateMap<SparePartList, SparePartListDto>().ReverseMap();

            CreateMap<TechnicialSpecification, TechnicialSpecificationsDto>();
            CreateMap<TechnicialSpecification, TechnicialSpecificationDto>().ReverseMap();
           

            CreateMap<User, UsersDto>()
                .ForMember(g => g.Gender, a => a.MapFrom(x => x.Gender.Description ?? ""))
                .ForMember(b => b.BranchOffice, z => z.MapFrom(x => x.BranchOffice.BranchName ?? ""));
            CreateMap<User, UserDto>().ReverseMap();



        }
    }
}