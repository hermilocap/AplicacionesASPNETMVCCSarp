using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//permite ejecutar reglas de validacion definidas

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WAValidarDataAnotacion.Models
{
    public class CursoValidar
    {
        [DisplayName("Codigo del curso")]
        public int codigo_c { get; set; }

        [DisplayName("Nombre del curos")]
        [Required(ErrorMessage ="El nombre del curso es requerido")]
        [StringLength(30, MinimumLength =3, ErrorMessage ="No mas de 30 carteres")]
       
        public string nombre_c { get; set; }

        [DisplayName("Email del curso")]
        [Required(ErrorMessage = "Email del curso es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "No mas de 50 carateres")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string correo_c { get; set; }

        [DisplayName("Creditos del curso")]
        [Required(ErrorMessage = "Numero de creditos de curso es requerido")]
        [Range(1,6)]
        public int credito_c { get; set;}

    }
}