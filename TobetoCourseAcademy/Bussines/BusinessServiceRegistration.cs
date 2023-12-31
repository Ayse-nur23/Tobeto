﻿using Business.Absracts;
using Business.Concretes;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICourseService, CourseManager>();

            return services;
        }

    }
}
