﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ByteBank.Forum.ViewModels
{
    public class ContaRegistrarViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Nome comppleto")]
        public string NomeCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }


    }
}