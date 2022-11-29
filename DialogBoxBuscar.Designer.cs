namespace Proyecto_Final_POO
{
    partial class DialogBoxBuscar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBoxBuscar));
            this.cmbBuscaPago = new System.Windows.Forms.ComboBox();
            this.txtBuscaN = new System.Windows.Forms.TextBox();
            this.dtpBusca = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toti = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuscaPago
            // 
            this.cmbBuscaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscaPago.FormattingEnabled = true;
            this.cmbBuscaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta débito",
            "Tarjeta crédito",
            "Transferencia",
            "Otro"});
            this.cmbBuscaPago.Location = new System.Drawing.Point(12, 42);
            this.cmbBuscaPago.Name = "cmbBuscaPago";
            this.cmbBuscaPago.Size = new System.Drawing.Size(211, 21);
            this.cmbBuscaPago.TabIndex = 27;
            this.cmbBuscaPago.Visible = false;
            // 
            // txtBuscaN
            // 
            this.txtBuscaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaN.Location = new System.Drawing.Point(12, 42);
            this.txtBuscaN.Name = "txtBuscaN";
            this.txtBuscaN.Size = new System.Drawing.Size(211, 22);
            this.txtBuscaN.TabIndex = 25;
            this.txtBuscaN.Visible = false;
            this.txtBuscaN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaN_KeyPress);
            // 
            // dtpBusca
            // 
            this.dtpBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBusca.Location = new System.Drawing.Point(12, 42);
            this.dtpBusca.Name = "dtpBusca";
            this.dtpBusca.Size = new System.Drawing.Size(211, 22);
            this.dtpBusca.TabIndex = 26;
            this.dtpBusca.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(132, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 29);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.SystemColors.Control;
            this.btnDo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDo.Location = new System.Drawing.Point(12, 70);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(91, 29);
            this.btnDo.TabIndex = 28;
            this.btnDo.Text = "Aceptar";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // DialogBoxBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 110);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.cmbBuscaPago);
            this.Controls.Add(this.txtBuscaN);
            this.Controls.Add(this.dtpBusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBoxBuscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.DialogBoxBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuscaPago;
        private System.Windows.Forms.TextBox txtBuscaN;
        private System.Windows.Forms.DateTimePicker dtpBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toti;
    }
}