using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Invocar
            MostrarMensaje();
        }

        //metodo para mostrar el mensaje de navegador
        public void MostrarMensaje()
        {
            Car car = new Car();
            string msj = car.stop();
            LblMensaje.Text = msj;
        }


    }
}