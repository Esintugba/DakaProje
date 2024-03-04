using AutoMapper;
using Mekel.EntityLayer.Concrete;
using Mekel.WebUI.Dtos.AboutDto;
using Mekel.WebUI.Dtos.BlogDto;
using Mekel.WebUI.Dtos.CategoryDto;
using Mekel.WebUI.Dtos.ChefDto;
using Mekel.WebUI.Dtos.ContactDto;
using Mekel.WebUI.Dtos.GalleryDto;
using Mekel.WebUI.Dtos.HomeDto;
using Mekel.WebUI.Dtos.MenuDto;
using Mekel.WebUI.Dtos.MessageCategoryDto;
using Mekel.WebUI.Dtos.RegisterDto;
using Mekel.WebUI.Dtos.ReservationDto;
using Mekel.WebUI.Dtos.SendMessageDto;

namespace Mekel.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
            CreateMap<CreateAboutDto,About>().ReverseMap();

            CreateMap<ResultBlogDto, Blog>().ReverseMap();
            CreateMap<UpdateBlogDto, Blog>().ReverseMap();
            CreateMap<CreateBlogDto, Blog>().ReverseMap();
            CreateMap<BlogDetailDto, Blog>().ReverseMap();

            CreateMap<ResultCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();

            CreateMap<ResultChefDto, Chef>().ReverseMap();
            CreateMap<UpdateChefDto, Chef>().ReverseMap();
            CreateMap<CreateChefDto, Chef>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<GetMessageByIDDto, Contact>().ReverseMap();
            CreateMap<InboxContactDto, Contact>().ReverseMap();

            CreateMap<ResultMessageCategoryDto, MessageCategory>().ReverseMap();

            CreateMap<CreateSendMessage,SendMessage>().ReverseMap();
            CreateMap<ResultSendboxDto,SendMessage>().ReverseMap();
           

            CreateMap<ResultGalleryDto, Gallery>().ReverseMap();
            CreateMap<UpdateGalleryDto, Gallery>().ReverseMap();
            CreateMap<CreateGalleryDto, Gallery>().ReverseMap();

            CreateMap<ResultHomeDto, Home>().ReverseMap();
            CreateMap<UpdateHomeDto, Home>().ReverseMap();
            CreateMap<CreateHomeDto, Home>().ReverseMap();

            CreateMap<ResultMenuDto, Menu>().ReverseMap();
            CreateMap<UpdateMenuDto, Menu>().ReverseMap();
            CreateMap<CreateMenuDto, Menu>().ReverseMap();

            CreateMap<ResultReservationDto, Reservation>().ReverseMap();
            CreateMap<ResultLast6ReservationDto, Reservation>().ReverseMap();
            CreateMap<UpdateReservationDto, Reservation>().ReverseMap();
            CreateMap<CreateReservationDto, Reservation>().ReverseMap();
            CreateMap<ApprovedReservationDto, Reservation>().ReverseMap();
           
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
        }
    }
}
