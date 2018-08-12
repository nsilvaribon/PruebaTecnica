
using AdministracionUsuarios.WcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionUsuarios.WcfService
{
    public class TiposDocumentoNegocio
    {
        AministracionUsuariosEntities context = new AministracionUsuariosEntities();

        public List<TiposDocumento> GetTiposDocumentos()
        {
            TiposDocumentoRepositorio _repositorio = new TiposDocumentoRepositorio(context);
            return _repositorio.GetAll();
        }

       


    }
}
