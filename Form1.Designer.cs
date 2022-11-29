namespace Proyecto_Final_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lsvVentas = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFormaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.laVentaMásAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laVentaMásBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esteProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvVentas
            // 
            this.lsvVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lsvVentas.BackgroundImage")));
            this.lsvVentas.BackgroundImageTiled = true;
            this.lsvVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1});
            this.lsvVentas.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvVentas.GridLines = true;
            this.lsvVentas.HideSelection = false;
            this.lsvVentas.Location = new System.Drawing.Point(12, 35);
            this.lsvVentas.Name = "lsvVentas";
            this.lsvVentas.Size = new System.Drawing.Size(701, 302);
            this.lsvVentas.TabIndex = 0;
            this.lsvVentas.UseCompatibleStateImageBehavior = false;
            this.lsvVentas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            this.columnHeader5.Width = 36;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nombre";
            this.columnHeader7.Width = 258;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cantidad";
            this.columnHeader8.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Precio";
            this.columnHeader9.Width = 99;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Forma de pago";
            this.columnHeader1.Width = 115;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.acercaDeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasLasVentasToolStripMenuItem,
            this.toolStripMenuItem3,
            this.porFechaToolStripMenuItem,
            this.porNombreToolStripMenuItem,
            this.porFormaDePagoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.laVentaMásAltaToolStripMenuItem,
            this.laVentaMásBajaToolStripMenuItem});
            this.mostrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarToolStripMenuItem.Image")));
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar...";
            // 
            // todasLasVentasToolStripMenuItem
            // 
            this.todasLasVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("todasLasVentasToolStripMenuItem.Image")));
            this.todasLasVentasToolStripMenuItem.Name = "todasLasVentasToolStripMenuItem";
            this.todasLasVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todasLasVentasToolStripMenuItem.Text = "Todas las ventas";
            this.todasLasVentasToolStripMenuItem.Click += new System.EventHandler(this.todasLasVentasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porFechaToolStripMenuItem.Image")));
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porFechaToolStripMenuItem.Text = "Por fecha";
            this.porFechaToolStripMenuItem.Click += new System.EventHandler(this.porFechaToolStripMenuItem_Click);
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porNombreToolStripMenuItem.Image")));
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // porFormaDePagoToolStripMenuItem
            // 
            this.porFormaDePagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porFormaDePagoToolStripMenuItem.Image")));
            this.porFormaDePagoToolStripMenuItem.Name = "porFormaDePagoToolStripMenuItem";
            this.porFormaDePagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porFormaDePagoToolStripMenuItem.Text = "Por forma de pago";
            this.porFormaDePagoToolStripMenuItem.Click += new System.EventHandler(this.porFormaDePagoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // laVentaMásAltaToolStripMenuItem
            // 
            this.laVentaMásAltaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("laVentaMásAltaToolStripMenuItem.Image")));
            this.laVentaMásAltaToolStripMenuItem.Name = "laVentaMásAltaToolStripMenuItem";
            this.laVentaMásAltaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.laVentaMásAltaToolStripMenuItem.Text = "La venta más alta";
            this.laVentaMásAltaToolStripMenuItem.Click += new System.EventHandler(this.laVentaMásAltaToolStripMenuItem_Click);
            // 
            // laVentaMásBajaToolStripMenuItem
            // 
            this.laVentaMásBajaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("laVentaMásBajaToolStripMenuItem.Image")));
            this.laVentaMásBajaToolStripMenuItem.Name = "laVentaMásBajaToolStripMenuItem";
            this.laVentaMásBajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.laVentaMásBajaToolStripMenuItem.Text = "La venta más baja";
            this.laVentaMásBajaToolStripMenuItem.Click += new System.EventHandler(this.laVentaMásBajaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirVentaToolStripMenuItem,
            this.toolStripMenuItem5,
            this.modificarVentaToolStripMenuItem,
            this.borrarVentaToolStripMenuItem});
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // añadirVentaToolStripMenuItem
            // 
            this.añadirVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("añadirVentaToolStripMenuItem.Image")));
            this.añadirVentaToolStripMenuItem.Name = "añadirVentaToolStripMenuItem";
            this.añadirVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirVentaToolStripMenuItem.Text = "Añadir venta";
            this.añadirVentaToolStripMenuItem.Click += new System.EventHandler(this.añadirVentaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // modificarVentaToolStripMenuItem
            // 
            this.modificarVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarVentaToolStripMenuItem.Image")));
            this.modificarVentaToolStripMenuItem.Name = "modificarVentaToolStripMenuItem";
            this.modificarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarVentaToolStripMenuItem.Text = "Modificar venta";
            this.modificarVentaToolStripMenuItem.Click += new System.EventHandler(this.modificarVentaToolStripMenuItem_Click);
            // 
            // borrarVentaToolStripMenuItem
            // 
            this.borrarVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarVentaToolStripMenuItem.Image")));
            this.borrarVentaToolStripMenuItem.Name = "borrarVentaToolStripMenuItem";
            this.borrarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarVentaToolStripMenuItem.Text = "Borrar venta";
            this.borrarVentaToolStripMenuItem.Click += new System.EventHandler(this.borrarVentaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esteProgramaToolStripMenuItem});
            this.acercaDeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem1.Image")));
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(97, 21);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de...";
            // 
            // esteProgramaToolStripMenuItem
            // 
            this.esteProgramaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("esteProgramaToolStripMenuItem.Image")));
            this.esteProgramaToolStripMenuItem.Name = "esteProgramaToolStripMenuItem";
            this.esteProgramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esteProgramaToolStripMenuItem.Text = "Este programa";
            this.esteProgramaToolStripMenuItem.Click += new System.EventHandler(this.esteProgramaToolStripMenuItem_Click);
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualDeUsuarioToolStripMenuItem.Image")));
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(725, 349);
            this.Controls.Add(this.lsvVentas);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvVentas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem laVentaMásAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laVentaMásBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem modificarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVentaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem porFormaDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esteProgramaToolStripMenuItem;
    }
}

