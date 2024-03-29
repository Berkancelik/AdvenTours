﻿using AutoMapper;
using DTOLayer.DTOs.AnnoucmenetDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnoucementAddDTOs, Annoucement>();
            CreateMap<Annoucement, AnnoucementAddDTOs>();

            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();

            CreateMap<AnnoucmeentListDTOs, Annoucement>();
            CreateMap<Annoucement, AnnoucmeentListDTOs>();

            CreateMap<AnnouncementUpdateDto, Annoucement>();
            CreateMap<Annoucement, AnnouncementUpdateDto>();


            //best practices
            CreateMap<SendMessageDto, ContactUS>().ReverseMap();
 
        }
    }
}
