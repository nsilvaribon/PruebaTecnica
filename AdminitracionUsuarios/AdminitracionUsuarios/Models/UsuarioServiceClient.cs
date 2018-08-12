using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.IO;
using System.Text;

namespace AdminitracionUsuarios.Models
{
    public class UsuarioServiceClient
    {

        public List<TiposDocumento> GetTiposDocumentos()
        {
            try
            {
                AdministracionServiceRef.AdministracionUsuariosServicioClient cliente = new AdministracionServiceRef.AdministracionUsuariosServicioClient();
                var lista = cliente.GetTiposDocumentos();
                var retorno = from l in lista
                              select new TiposDocumento() { Id = l.Id, TipoDocumento = l.TipoDocumento };
                return retorno.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                 AdministracionServiceRef.AdministracionUsuariosServicioClient cliente = new AdministracionServiceRef.AdministracionUsuariosServicioClient();
                var lista = cliente.GetAll();
                var retorno = from l in lista
                              select new Usuario()
                              {
                                  UserId = l.UserId,
                                  Ciudad = l.Ciudad,
                                  Departamento = l.Departamento,
                                  Direccion = l.Direccion,
                                  FechaNacimiento = l.FechaNacimiento.ToShortDateString(),
                                  NombreCompleto = l.NombreCompleto,
                                  NumeroDocumento = l.NumeroDocumento,
                                  Pais = l.Pais,
                                  TipoDocumento = l.TipoDocumento,
                                  TipoDocumentoSelecionado = new TiposDocumento()
                                  {
                                      Id = l.TipoDocumentoSelecionado.Id,
                                      TipoDocumento = l.TipoDocumentoSelecionado.TipoDocumento
                                  }

                              };
                return retorno.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Usuario Get(string id)
        {
            try
            {
                AdministracionServiceRef.AdministracionUsuariosServicioClient cliente = new AdministracionServiceRef.AdministracionUsuariosServicioClient();
                var usuario = cliente.Get(id);
                var retorno = new Usuario()
                {
                    UserId = usuario.UserId,
                    Ciudad = usuario.Ciudad,
                    Departamento = usuario.Departamento,
                    Direccion = usuario.Direccion,
                    FechaNacimiento = usuario.FechaNacimiento.ToShortDateString(),
                    NombreCompleto = usuario.NombreCompleto,
                    NumeroDocumento = usuario.NumeroDocumento,
                    Pais = usuario.Pais,
                    TipoDocumento = usuario.TipoDocumento,
                    TipoDocumentoSelecionado = new TiposDocumento()
                    {
                        Id = usuario.TipoDocumentoSelecionado.Id,
                        TipoDocumento = usuario.TipoDocumentoSelecionado.TipoDocumento
                    }

                };
                return retorno;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public bool Save(Usuario usuario)
        {
            try
            {
                AdministracionServiceRef.AdministracionUsuariosServicioClient cliente = new AdministracionServiceRef.AdministracionUsuariosServicioClient();
                
                var retorno = new AdministracionServiceRef.Usuario()
                {
                    UserId = usuario.UserId,
                    Ciudad = usuario.Ciudad,
                    Departamento = usuario.Departamento,
                    Direccion = usuario.Direccion,
                    FechaNacimiento = Convert.ToDateTime(usuario.FechaNacimiento),
                    NombreCompleto = usuario.NombreCompleto,
                    NumeroDocumento = usuario.NumeroDocumento,
                    Pais = usuario.Pais,
                    TipoDocumento = usuario.TipoDocumento,
                    TipoDocumentoSelecionado = new AdministracionServiceRef.TiposDocumento()
                    {
                        Id = usuario.TipoDocumentoSelecionado.Id,
                        TipoDocumento = usuario.TipoDocumentoSelecionado.TipoDocumento
                    }

                };

                bool res = cliente.Save(retorno);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Edit(Usuario usuario)
        {
            try
            {
                 AdministracionServiceRef.AdministracionUsuariosServicioClient cliente = new AdministracionServiceRef.AdministracionUsuariosServicioClient();

                var retorno = new AdministracionServiceRef.Usuario()
                {
                    UserId = usuario.UserId,
                    Ciudad = usuario.Ciudad,
                    Departamento = usuario.Departamento,
                    Direccion = usuario.Direccion,
                    FechaNacimiento = Convert.ToDateTime(usuario.FechaNacimiento),
                    NombreCompleto = usuario.NombreCompleto,
                    NumeroDocumento = usuario.NumeroDocumento,
                    Pais = usuario.Pais,
                    TipoDocumento = usuario.TipoDocumento,
                    TipoDocumentoSelecionado = new AdministracionServiceRef.TiposDocumento()
                    {
                        Id = usuario.TipoDocumentoSelecionado.Id,
                        TipoDocumento = usuario.TipoDocumentoSelecionado.TipoDocumento
                    }

                };

                bool res= cliente.Edit(retorno);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public bool Delete(string id)
        {
            try
            {
                 AdministracionServiceRef.AdministracionUsuariosServicioClient cliente = new AdministracionServiceRef.AdministracionUsuariosServicioClient();
                return cliente.Delete(id);
            }
            catch
            {

                return false;
            }
        }
    }
}