using AdminitracionUsuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminitracionUsuarios.ViewModels
{
    public class UsuarioViewModel
    {
        public Usuario Usuario { get; set; }
        public SelectList TiposDocumento { get; set; }
    }
}