using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
namespace proyectoUniversidad.MostrarProductos
{
    public partial class mostrarProductos : System.Web.UI.Page
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
        #endregion

        #region Methods
        public void llenarTabla()
        {
            DataAccessLayer dal = new DataAccessLayer();
            tabla1.DataSource = dal.cargarProductos();
            tabla1.DataBind();
        }
        #endregion
    }
}