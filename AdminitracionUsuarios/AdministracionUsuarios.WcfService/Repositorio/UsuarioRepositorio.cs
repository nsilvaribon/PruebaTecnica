
using AdministracionUsuarios.WcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionUsuarios.WcfService
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {
        private new AministracionUsuariosEntities context
        {
            get { return base.context as AministracionUsuariosEntities; }
        }

        public UsuarioRepositorio(AministracionUsuariosEntities context) : base(context)
        {
        }
    }
}
