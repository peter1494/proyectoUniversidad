using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;

namespace proyectoUniversidad.Productos
{
    public partial class modificarProducto : System.Web.UI.Page
    {

        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProducto();
        }

        

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarProducto();
        }

        #endregion

        #region Methods

        public void cargarProducto()
        {
            string codigo = Request.QueryString.Get("id");
            DataTable dt = new DataTable();
            DataAccessLayer dal = new DataAccessLayer();
            dt = dal.buscarProductoPorCodigo(codigo);
            //nombre = dtAccess.Rows[r - 1][1].ToString();

            txtNombre.Text = dt.Rows[0][2].ToString();
            txtCodigo.Text = dt.Rows[0][1].ToString();
            txtCantidad.Text = dt.Rows[0][3].ToString();
            chkboxActivo.Checked = Convert.ToBoolean(dt.Rows[0][4]);
        }

        public void guardarProducto()
        {

            string mensaje = string.Empty;
            DataAccessLayer dal = new DataAccessLayer();
            bool activo = false;
            if (chkboxActivo.Checked == true)
            {
                activo = true;
            }
            string nombre = string.Empty;
            int cantidad = 0;
            string codigo = string.Empty;
            cantidad = Convert.ToInt32(txtCantidad.Text);
            nombre = txtNombre.Text;
            codigo = txtCodigo.Text;

            mensaje = dal.modificarProducto(nombre, cantidad, activo, codigo);


        }
        #endregion
    }
}