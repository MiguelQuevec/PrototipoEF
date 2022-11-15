using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class PRODUCTOS : Form
    {
        public PRODUCTOS()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6002";
            TextBox[] Grupotextbox = { txtIDproducto, txtNombreProducto, txtDescripProducto, txtPrecioProducto };
            TextBox[] Idtextbox = { txtIDproducto, txtNombreProducto, txtDescripProducto, txtPrecioProducto };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridProducto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridProducto, Grupotextbox, "PrototipoEF");
        }
    }
}
