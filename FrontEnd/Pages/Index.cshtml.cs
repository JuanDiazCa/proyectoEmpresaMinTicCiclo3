﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace FrontEnd.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Credencial Credencial {get; set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }

    public class Credencial
    {
        [Required(ErrorMessage = "Por favor escribe tu nombre de usuario")]
        public string Usuario {get; set;}

        [Required(ErrorMessage = "Por favor escribe tu contraseña")]
        [DataType(DataType.Password)]
        public string Clave {get; set;}
    }
}
