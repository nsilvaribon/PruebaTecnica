
using AdministracionUsuarios.WcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdministracionUsuarios.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdministracionUsuariosServicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdministracionUsuariosServicio.svc or AdministracionUsuariosServicio.svc.cs at the Solution Explorer and start debugging.
    public class AdministracionUsuariosServicio : IAdministracionUsuariosServicio
    {


        public List<TiposDocumento> GetTiposDocumentos()
        {
            TiposDocumentoNegocio _repositorio = new TiposDocumentoNegocio();
            return _repositorio.GetTiposDocumentos();
        }

        public List<Usuario> GetAll()
        {
            UsuarioNegocio _repositorio = new UsuarioNegocio();
            List<Usuario> usuarios = _repositorio.GetAll();
            return usuarios;
        }

        public Usuario Get(string id)
        {
            UsuarioNegocio _repositorio = new UsuarioNegocio();
            return _repositorio.Get(id);
        }

        public bool Save(Usuario entity)
        {
            try
            {
                UsuarioNegocio _repositorio = new UsuarioNegocio();
                _repositorio.Save(entity);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Edit(Usuario entity)
        {
            try
            {
                UsuarioNegocio _repositorio = new UsuarioNegocio();
                _repositorio.Edit(entity);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                UsuarioNegocio _repositorio = new UsuarioNegocio();
                _repositorio.Delete(id);
                return true;
            }
            catch
            {

                return false;
            }
        }


    }
}
