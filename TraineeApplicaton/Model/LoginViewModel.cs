﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeApplication.Model
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = ("Логін"))]
        public string Username { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        
        [Display(Name = "Запам'ятати мене")]
        public bool RememberMe { get; set; }
    }
}
