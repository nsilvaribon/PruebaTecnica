using AdministracionUsuarios.WcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministracionUsuarios.WcfService
{
    public class TiposDocumentoRepositorio : Repositorio<TiposDocumento>
    {
        private new AministracionUsuariosEntities context
        {
            get { return base.context as AministracionUsuariosEntities; }
        }

        public TiposDocumentoRepositorio(AministracionUsuariosEntities context) : base(context)
        {
        }
    }
}