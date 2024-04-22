//using CapaEntidad;
//using CapaUtilitarios;
//using CapaEntidad.CargaContactosCLS;
//using CapaNegocio;
//using CapaNegocio.CargaContactosBL;
//using CapaNegocio.GestionDeProyectosBL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

namespace TMGROUP.Pages.LoginTmg
{
    public class LoginModel : PageModel
    {
        //private readonly IWebHostEnvironment _hostingEnvironment;
        //// Constructor
        //public LoginModel(IWebHostEnvironment hostingEnvironment)
        //{
        //    _hostingEnvironment = hostingEnvironment;
        //}
        //USUARIO oUSUARIO = new USUARIO();
        //LoginBL obj = new LoginBL();
        //Alertas Alertas = new Alertas();
        public string Mensaje { get; set; }
        public string ltMensaje { get; set; }
        //public void OnGet()
        //{
        //    // Establecer cabeceras para evitar el almacenamiento en caché
        //    Response.Headers.Add("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
        //    Response.Headers.Add("Pragma", "no-cache"); // HTTP 1.0.
        //    Response.Headers.Add("Expires", "0"); // Proxies.

        //    if (!IsPostBack())
        //    {
        //        HttpContext.Session.Clear();

        //    }

        //}

        //public string ConstruirURLCompleta(string url)
        //{
        //    var rutaBase = Url.Content("~/");

        //    var urlCompleta = (rutaBase + url);

        //    // Obtener la ruta relativa desde el directorio raíz de la aplicación
        //    //var urlCompleta = $"{Request.Scheme}://{Request.Host}/{url}";


        //    return urlCompleta;
        //}

        //private bool IsPostBack()
        //{
        //    return Request.Method.ToUpper() == "POST";
        //}

        //public List<LoginCLS> ObtenerlistaPaginas(int idPerfil)
        //{
        //    LoginBL obj = new LoginBL();
        //    return obj.ObtenerListaPaginas(idPerfil);

        //}
        //public IActionResult OnPostCerrarSesion()
        //{
        //    HttpContext.Session.Clear();
        //    var urlCompleta = ConstruirURLCompleta("LoginTmg/Login");

        //    return Redirect(urlCompleta); 
        //}

        //public IActionResult OnPostLogin(string Usuario, string Clave)
        //{
        //    var urlCompleta = ConstruirURLCompleta("Index");
        //    //VALIDACIONES PARA USUARIO CONTRASEÑA VACIOS
        //    if (string.IsNullOrWhiteSpace(Usuario))
        //    {

        //        Mensaje = "Ingrese usuario..!";
        //        ltMensaje = Alertas.GenerarHtmlAlerta(Alertas.Tipos_Alerta.Danger, Mensaje);
        //        return Page();
        //    }
        //    else
        //    {
        //        bool usuarioExiste = obj.UserExist(Usuario);

        //        if (!usuarioExiste)
        //        {
        //            // Usuario no existe, muestra mensaje de error
        //            Mensaje = "Usuario no válido..!";
        //            ltMensaje = Alertas.GenerarHtmlAlerta(Alertas.Tipos_Alerta.Danger, Mensaje);
        //            return Page();
        //        }
        //    }
        //    if (string.IsNullOrWhiteSpace(Clave))
        //    {

        //        Mensaje = "Ingrese Contraseña..!";
        //        ltMensaje = Alertas.GenerarHtmlAlerta(Alertas.Tipos_Alerta.Warning, Mensaje);
        //        return Page();
        //    }

        //    USUARIO oUsuario = obj.LoginUsuario(Usuario, Clave);

        //    if (oUsuario.PERFIL != 0)
        //    {
        //        string objCadena = JsonConvert.SerializeObject(oUsuario);
        //        HttpContext.Session.SetString("persona", objCadena);
        //        //OBTENEMOS LA LISTA DE PAGINAS QUE PUEDE VER EL USUARIO
        //        List<LoginCLS> listaPagina = ObtenerlistaPaginas(oUsuario.PERFIL);
        //        string objLista = JsonConvert.SerializeObject(listaPagina);
        //        HttpContext.Session.SetString("menus", objLista);

        //        HttpContext.Session.SetString("ID_USUARIO", oUsuario.IDUSUARIO);
        //        HttpContext.Session.SetInt32("PERFIL", oUsuario.PERFIL);
        //        HttpContext.Session.SetString("APELLIDOS", oUsuario.APELLIDOS);
        //        HttpContext.Session.SetString("NOMBRES", oUsuario.NOMBRES);
        //        HttpContext.Session.SetInt32("DOC_IDEN", oUsuario.DOC_IDEN);
        //        HttpContext.Session.SetString("EMAIL_CORP", oUsuario.EMAIL_CORP);
        //        HttpContext.Session.SetString("NO_CIA", oUsuario.NO_CIA);
        //        HttpContext.Session.SetString("COD_TRAB", oUsuario.COD_TRAB);

        //        return Redirect(urlCompleta);
        //    }
        //    else
        //    {
        //        Mensaje = "Contraseña incorrecta..!";
        //        ltMensaje = Alertas.GenerarHtmlAlerta(Alertas.Tipos_Alerta.Danger, Mensaje);
        //        return Page();

        //    }


        //}
    }
}
