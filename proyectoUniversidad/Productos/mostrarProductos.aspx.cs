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
            if (!IsPostBack)
            {
                llenarTabla();
            }
            
        }

        protected void tablaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = tablaProductos.SelectedRow;
            string codigo = row.Cells[0].Text;
            Page.Response.Redirect("modificarProducto.aspx?id=" + codigo);
        }
        #endregion

        #region Methods
        public void llenarTabla()
        {
            DataAccessLayer dal = new DataAccessLayer();
            tablaProductos.DataSource = dal.cargarProductos();
            tablaProductos.DataBind();
        }
        #endregion
    }
}