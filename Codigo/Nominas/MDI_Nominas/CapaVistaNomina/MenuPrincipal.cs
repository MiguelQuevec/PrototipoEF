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
    public partial class MenuPrincipal : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public MenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();

            Button[] apps = { btnCliente, btnProducto, btnAsFactura, btnRproductos, btnSegNomina,btnInfo};
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(6001, apps[0]);
            cnseg.getAccesoApp(6002, apps[1]);

            cnseg.getAccesoApp(6101, apps[2]);

            cnseg.getAccesoApp(6201, apps[3]);

            cnseg.getAccesoApp(6301, apps[4]);

        }

        private void customizeDesing()
        {
            panelCatalogos.Visible = false;
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
            panelSeguridad.Visible = false;
            panelAyuda.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCatalogos.Visible == true)
                panelCatalogos.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false; 
            if (panelAyuda.Visible == true)
                panelAyuda.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatalogos);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAyuda);
        }


        private void btnSegNomina_Click(object sender, EventArgs e)
        {
            Vista_Seguridad.Bitacora b = new Vista_Seguridad.Bitacora();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            AyudaInfo b = new AyudaInfo();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
            CLIENTES b = new CLIENTES();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            PRODUCTOS b = new PRODUCTOS();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnAsFactura_Click(object sender, EventArgs e)
        {
            FACTURA b = new FACTURA();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void btnRproductos_Click(object sender, EventArgs e)
        {
            ReportProductos b = new ReportProductos();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }
    }
}
