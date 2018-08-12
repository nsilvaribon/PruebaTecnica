using AdministracionUsuarios.WcfService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AdministracionUsuarios.WcfService
{
    [ServiceContract]
    public interface IAdministracionUsuariosServicio
    {
        [OperationContract]
        List<TiposDocumento> GetTiposDocumentos();

        [OperationContract]
        List<Usuario> GetAll();

        [OperationContract]
        Usuario Get(string id);

        [OperationContract]
        bool Save(Usuario entity);

        [OperationContract]
        bool Edit(Usuario entity);

        [OperationContract]
        bool Delete(string id);
      
    }
}
