﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.Application.Wrappers
{
    public class LoginResponse : BaseResponse
    {
        public string Token { get; set; }

    }
}