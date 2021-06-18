using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo ingrese letras")]
        public string PacienteNombre { get; set; }

        [Required(ErrorMessage = "El segundo nombre es obligatorio")]
        [Display(Name = "Segundo Nombre")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo ingrese letras")]
        public string PacienteSegundoNombre { get; set; }

        [Required(ErrorMessage = "Los Apellidos son obligatorios")]
        [Display(Name = "Apellidos")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo ingrese letras")]
        public string PacienteApellido { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]
        public string PacienteCorreo { get; set; }

        [Display(Name = "Nombre Acompañante")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo ingrese letras")]
        public string PacienteAcompañanteNombre { get; set; }

        [Display(Name = "Apellido Acompañante")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo ingrese letras")]
        public string PacienteAcompañanteApellido { get; set; }

        [Required(ErrorMessage = "Direccion de calle es obligatoria")]
        [Display(Name = "Direccion Calle")]
        public string PacienteDireccionCalle { get; set; }

        [Display(Name = "Direccion Calle Linea 2")]
        public string PacienteDireccionCalleLinea2 { get; set; }

        [Display(Name = "Ciudad")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo ingrese letras")]
        public string PacienteCiudad { get; set; }

        [Display(Name = "Provincia")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo ingrese letras")]
        public string PacienteProvincia { get; set; }

        [Display(Name = "Postal")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string PacienteCodigoPostal { get; set; }

        [Display(Name = "CodTelefono")]
        [Required(ErrorMessage = "Codigo de area obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string PacienteCodigoAreaTelefono { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Telefono es obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string PacienteNumeroTelefono { get; set; }

        [Display(Name = "CodCelular")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string PacienteCodigoAreaCelular { get; set; }

        [Display(Name = "Celular")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string PacienteNumeroCelular { get; set; }
    }
}
