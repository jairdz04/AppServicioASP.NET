using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppServicioASP.NET.Modelo;

namespace AppServicioASP.NET.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Package TwoDayPackage = new Package(24, "jose","zaragocilla","cartagena","bolivar", 4501,4506,70.000, 1.3);
            //int codigo, string nombre, string direccion, string ciudad, string estado, int postalRemitente, int postalDestinatario, double peso, double costo, double cuota
            ;


           
        }
    }
}