using AdminitracionUsuarios.Models;
using AdminitracionUsuarios.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminitracionUsuarios.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            UsuarioServiceClient cliente = new UsuarioServiceClient();
            return Json(cliente.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListTiposDocumentos()
        {
            UsuarioServiceClient cliente = new UsuarioServiceClient();
            return Json(cliente.GetTiposDocumentos(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Save(Usuario usuario)
        {
            UsuarioServiceClient cliente = new UsuarioServiceClient();
            return Json(cliente.Save(usuario), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Get(int id)
        {
            UsuarioServiceClient cliente = new UsuarioServiceClient();
            return Json(cliente.Get(id.ToString()), JsonRequestBehavior.AllowGet);
        }
       
        public JsonResult Update(Usuario usuario)
        {
            UsuarioServiceClient cliente = new UsuarioServiceClient();
            return Json(cliente.Edit(usuario), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {
            UsuarioServiceClient cliente = new UsuarioServiceClient();
            return Json(cliente.Delete(id.ToString()), JsonRequestBehavior.AllowGet);
        }

        


    }
}