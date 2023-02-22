using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.InstructorDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.DIContainer
{
    public static class Extensions
    {
        public static void Containerdependencies(this IServiceCollection services)
        {           
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IAppRoleDal, EfAppRoleDal>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();

        }

        //validator-dto 
        public static void CustomizedValidator(this IServiceCollection services)
        {
            services.AddTransient < IValidator<InstructorAddDTO>, InstructorAddValidator>();
        }
    }
}
