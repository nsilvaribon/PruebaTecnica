using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminitracionUsuarios.Models
{
    public class Usuario
    {
        
        public int UserId { get; set; }
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Fecha Nacimiento")]
        public string FechaNacimiento { get; set; }
        [Display(Name = "Tipo Documento")]
        public int TipoDocumento { get; set; }
        [Display(Name = "Número Documento")]
        public string NumeroDocumento { get; set; }
        [Display(Name = "Pais")]
        public string Pais { get; set; }
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        public TiposDocumento TipoDocumentoSelecionado { get; set; }
    }
}