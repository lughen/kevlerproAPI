



using EntitiesClasses.Entities;
using ViewModel.BrandViewModel;

namespace ViewModel.AutoMapper;
    public class AutoMappers : Profile
    {
    public AutoMappers()
    {
        CreateMap<Brand, BrandDto>().ReverseMap();
      
        //CreateMap<User, UserListDto>()
        //       .ForMember(dest =>
        //       dest.Name,
        //       opt => opt.MapFrom(src => src.)).ReverseMap();

    }



}