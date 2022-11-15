
namespace CapaVistaNomina
{
    partial class PRODUCTOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 56);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(80, 72);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 8;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPrecioProducto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDescripProducto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNombreProducto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIDproducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridProducto);
            this.panel2.Location = new System.Drawing.Point(24, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 224);
            this.panel2.TabIndex = 10;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtPrecioProducto.Location = new System.Drawing.Point(16, 176);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(192, 22);
            this.txtPrecioProducto.TabIndex = 13;
            this.txtPrecioProducto.Tag = "Precio_producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(16, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Tag = "";
            this.label5.Text = "Precio";
            // 
            // txtDescripProducto
            // 
            this.txtDescripProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtDescripProducto.Location = new System.Drawing.Point(16, 128);
            this.txtDescripProducto.Name = "txtDescripProducto";
            this.txtDescripProducto.Size = new System.Drawing.Size(192, 22);
            this.txtDescripProducto.TabIndex = 14;
            this.txtDescripProducto.Tag = "Descripcion_producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Tag = "";
            this.label4.Text = "Descripción";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtNombreProducto.Location = new System.Drawing.Point(16, 80);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(192, 22);
            this.txtNombreProducto.TabIndex = 15;
            this.txtNombreProducto.Tag = "Nombre_producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // txtIDproducto
            // 
            this.txtIDproducto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtIDproducto.Location = new System.Drawing.Point(16, 32);
            this.txtIDproducto.Name = "txtIDproducto";
            this.txtIDproducto.Size = new System.Drawing.Size(192, 22);
            this.txtIDproducto.TabIndex = 5;
            this.txtIDproducto.Tag = "pk_id_producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Producto";
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AllowUserToAddRows = false;
            this.dataGridProducto.AllowUserToDeleteRows = false;
            this.dataGridProducto.AllowUserToResizeColumns = false;
            this.dataGridProducto.AllowUserToResizeRows = false;
            this.dataGridProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Location = new System.Drawing.Point(240, 16);
            this.dataGridProducto.MultiSelect = false;
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.ReadOnly = true;
            this.dataGridProducto.RowHeadersVisible = false;
            this.dataGridProducto.RowHeadersWidth = 51;
            this.dataGridProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridProducto.ShowEditingIcon = false;
            this.dataGridProducto.Size = new System.Drawing.Size(464, 201);
            this.dataGridProducto.TabIndex = 0;
            this.dataGridProducto.Tag = "tbl_producto";
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridProducto;
    }
}