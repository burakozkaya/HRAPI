﻿using HrApp.Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.Domain.Entities
{
    public class AppUser : IdentityUser, IEntity
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public DateTime BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public string TurkishIdentificationNumber {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public string Department { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public decimal Salary { get; set; }
    }
}