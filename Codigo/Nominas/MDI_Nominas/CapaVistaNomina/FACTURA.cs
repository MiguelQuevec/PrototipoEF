using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorNomina;

namespace CapaVistaNomina
{
    public partial class FACTURA : Form
    {
        string table = "tbl_factura";
        int cont = 1;
        Controlador cn = new Controlador();

        public FACTURA()
        {
            InitializeComponent();
        }

        public void actualizardatagriew()
        {
            string id = txtCadenas1.Text;
            cn.llenarListAsignaciones(ListaAsignacion.Tag.ToString(), ListaAsignacion, id);
        }

        public void limpiar()
        {
            txtCadenas1.Text = "";
            txtCadenas2.Text = "";
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6101";
            TextBox[] Grupotextbox = { txtIDfactura, txtCadenas1, txtCadenas2, txtTotal };
            TextBox[] Idtextbox = { txtIDfactura, txtCadenas1, txtCadenas2, txtTotal };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = ListaAsignacion;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(ListaAsignacion, Grupotextbox, "PrototipoEF");
        }


        public void getId()
        {
            try
            {
                string dato;
                dato = ListaDatos.CurrentRow.Cells[0].Value.ToString();
                txtCadenas1.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }

        public void getIds()
        {
            try
            {
                string dato;
                dato = ListaDatos.CurrentRow.Cells[0].Value.ToString();
                txtCadenas2.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }


        private void ListaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cont == 1)
            {
                //Metodo que lleva valor Unico
                getId();
            }
            else if (cont == 2)
            {
                //Metodo que lleva valor con coma 1,2,3
                getIds();
            }
        }

        private void ListaAsignacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String dato1 = ListaAsignacion.CurrentRow.Cells[0].Value.ToString();
                String dato2 = ListaAsignacion.CurrentRow.Cells[2].Value.ToString();
                int campo1 = int.Parse(dato1);
                string condicion1 = txtCadenas1.Tag.ToString();
                int campo2 = int.Parse(dato2);
                string condicion2 = txtProducto.Tag.ToString();
                cn.eliminarAsiganaciones(table, condicion1, campo1, condicion2, campo2);
                //listAplicacionPerfil.Columns.Clear();
                string id = txtCadenas1.Text;
                cn.llenarListAsignaciones(ListaAsignacion.Tag.ToString(), ListaAsignacion, id);
            }
            else
            {
                limpiar();
            }
        }

        private void FACTURA_Load(object sender, EventArgs e)
        {
            txtProducto.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cont = 1;
            ListaDatos.Columns.Clear();
            cn.llenarListCliente(ListaDatos.Tag.ToString(), ListaDatos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont = 2;
            ListaDatos.Columns.Clear();
            cn.llenarListProducto(ListaDatos.Tag.ToString(), ListaDatos);
        }
    }
}
