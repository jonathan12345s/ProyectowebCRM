using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyetcoweb2.Models
{
    public class usuario
    {


        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Usuario Requerido.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Clave  Requerida.")]
        public string Password { get; set; }

        //usuario y clave
    }
}