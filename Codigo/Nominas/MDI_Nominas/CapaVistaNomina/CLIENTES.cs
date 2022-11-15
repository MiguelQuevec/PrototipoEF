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
    public partial class CLIENTES : Form
    {
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6001";
            TextBox[] Grupotextbox = { txtIDcliente, txtNombreCliente, txtEmailCliente, txtDirecCliente, txtTelCliente };
            TextBox[] Idtextbox = { txtIDcliente, txtNombreCliente, txtEmailCliente, txtDirecCliente, txtTelCliente };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridCliente;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridCliente, Grupotextbox, "PrototipoEF");
        }
    }
}
