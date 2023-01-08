using BusinessLayer.Abstract;
using BusinessLayer.Abstract.NewFolder.AbstractUnitOfWork;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.UnitOfWorkConcrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnoucmenetDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IAnnoucementService, AnnoucementManager>();
            services.AddScoped<IAnnoucementDal, EfAnnoucmenetDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

                    
        }
        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnoucementAddDTOs>, AnnoucementValidator>();
        }
    }
}
