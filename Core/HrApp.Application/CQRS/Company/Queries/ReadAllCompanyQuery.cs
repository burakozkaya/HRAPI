﻿using HrApp.Application.Dtos;
using HrApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.Application.CQRS.Company.Queries
{
    public class ReadAllCompanyQuery : IRequest<ServiceResponse<List<CompanyDto>>>
    {
        public bool isFree { get; set; }
    }
}
