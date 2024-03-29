﻿using FluentValidation;
using HrApp.Application.Interfaces;
using HrApp.Application.Services;
using HrApp.Application.Validators;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.Application.Extensions
{
    public static class ApplicationDependencies
    {
        public static void AddApplicationDependencies(this IServiceCollection services)
        {
            //todo: expception yenilebilir
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationDependencies).Assembly));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblyContaining<CreateLeaveValidator>();
            services.AddScoped<IEmailService, EmailManager>();
        }
    }
}
