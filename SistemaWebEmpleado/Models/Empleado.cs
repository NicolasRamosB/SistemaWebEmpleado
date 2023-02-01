using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OperaWebSitee.Validations;

namespace SistemaWebEmpleado.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        public int Id { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Nombre")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Apellido")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el DNI")]
        public string DNI { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Legajo")]
        [RegularExpression(@"^[A-Z]{1}[0-9]{5}$", ErrorMessage = "Solo se aceptan una letra y 5 numeros")]
        public string Legajo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el Fecha")]
        [CheckValidDateTime]
        [DisplayFormat(ApplyFormatInEditMode = true,
            DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime  FechaNacimiento { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Legajo")]
        public string Titulo { get; set; }
    }
}
