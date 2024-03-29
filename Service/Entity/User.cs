﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Service.Entity
{
    public class User
    {
        [Key]
        public Guid Id  { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}