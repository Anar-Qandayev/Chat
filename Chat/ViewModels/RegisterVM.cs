﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Chat.ViewModels
{
    public class RegisterVM
    {
        [Required,MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public IFormFile Image { get; set; }
    }
}
