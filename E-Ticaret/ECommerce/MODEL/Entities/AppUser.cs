﻿using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class AppUser:EntityRepository
    {
        public AppUser()
        {
            IsActive = false;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImagePath { get; set; }
        public Guid ActivationId { get; set; }
        public bool IsActive { get; set; }
    }
}
