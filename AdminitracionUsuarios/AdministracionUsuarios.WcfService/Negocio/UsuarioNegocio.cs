
using AdministracionUsuarios.WcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionUsuarios.WcfService
{
    public class UsuarioNegocio
    {
        AministracionUsuariosEntities context = new AministracionUsuariosEntities();


        public List<Usuario> GetAll()
        {
            UsuarioRepositorio _repositorio = new UsuarioRepositorio(context);
            TiposDocumentoRepositorio tiposDocumento = new TiposDocumentoRepositorio(context);
            List<Usuario> usuarios = _repositorio.GetAll();
            foreach (var usuario in usuarios)
            {
                usuario.TipoDocumentoSelecionado = tiposDocumento.Get(usuario.TipoDocumento);
            }
            return usuarios;
        }

        public Usuario Get(string id)
        {
            UsuarioRepositorio _repositorio = new UsuarioRepositorio(context);
            Usuario usuario = _repositorio.Get(Convert.ToInt32(id));
            TiposDocumentoRepositorio tiposDocumento = new TiposDocumentoRepositorio(context);
            usuario.TipoDocumentoSelecionado = tiposDocumento.Get(usuario.TipoDocumento);
            return usuario;
        }

        public void Save(Usuario entity)
        {
            UsuarioRepositorio _repositorio = new UsuarioRepositorio(context);
            _repositorio.Save(entity);
        }

        public void Edit(Usuario entity)
        {
            UsuarioRepositorio _repositorio = new UsuarioRepositorio(context);
            _repositorio.Edit(entity);
        }
        
        public void Delete(string id)
        {
            UsuarioRepositorio _repositorio = new UsuarioRepositorio(context);
            _repositorio.Delete(Convert.ToInt32(id));
        }


    }
}
