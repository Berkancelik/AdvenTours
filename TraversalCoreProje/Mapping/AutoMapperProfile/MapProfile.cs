using DTOLayer.DTOs.AnnoucmenetDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.CityDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile: AutoMapper.Profile
    {
        public MapProfile()
        {
            CreateMap<AnnoucementAddDTOs, Annoucement>();
            CreateMap<Annoucement, AnnoucementAddDTOs>();

            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap <AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();

        }
    }
}
