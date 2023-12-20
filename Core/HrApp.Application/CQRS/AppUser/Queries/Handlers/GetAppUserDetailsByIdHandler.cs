﻿using AutoMapper;
using HrApp.Application.Helpers;
using HrApp.Application.Wrappers;
using HrApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HrApp.Application;

public class GetAppUserDetailsByIdHandler : IRequestHandler<GetAppUserDetailsById, ServiceResponse<AppUserDetailsDto>>
{
   private readonly UserManager<AppUser> userManager;
   private readonly IMapper mapper;

   public GetAppUserDetailsByIdHandler(UserManager<AppUser> userManager, IMapper mapper)
   {
      this.userManager = userManager;
      this.mapper = mapper;
   }
   public async Task<ServiceResponse<AppUserDetailsDto>> Handle(GetAppUserDetailsById request, CancellationToken cancellationToken)
   {
        var user = await userManager.FindByIdAsync(request.Id);

        if (user == null)
        {
           return new ServiceResponse<AppUserDetailsDto>() { Message = "User not found", Success = false };
        }

        var userDto = mapper.Map<AppUserDetailsDto>(user);

        if (user.ImageData == null) 
        {
            userDto.Image = "images/user/default.png";
        }
        else
        {
            userDto.Image = await ImageConversions.ConvertToIFormFile(user.ImageData);
        }

        return new ServiceResponse<AppUserDetailsDto>(userDto) { Message = "User details retrieved successfully", Success = true };
   }
}
