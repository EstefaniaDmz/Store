namespace Proyecto_Final_POO
{
    partial class DialogBoxModicaaarrrr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBoxModicaaarrrr));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelecc = new System.Windows.Forms.ComboBox();
            this.txtModi = new System.Windows.Forms.TextBox();
            this.dtpModi = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.toti = new System.Windows.Forms.ToolTip(this.components);
            this.cmbPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(133, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 29);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.SystemColors.Control;
            this.btnDo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDo.Location = new System.Drawing.Point(66, 163);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(91, 29);
            this.btnDo.TabIndex = 16;
            this.btnDo.Text = "Modificar";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(73, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id:";
            // 
            // nmrID
            // 
            this.nmrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrID.Location = new System.Drawing.Point(105, 12);
            this.nmrID.Name = "nmrID";
            this.nmrID.ReadOnly = true;
            this.nmrID.Size = new System.Drawing.Size(71, 22);
            this.nmrID.TabIndex = 18;
            this.nmrID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Modificar su:";
            // 
            // cmbSelecc
            // 
            this.cmbSelecc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecc.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelecc.FormattingEnabled = true;
            this.cmbSelecc.Items.AddRange(new object[] {
            "Fecha",
            "Nombre",
            "Cantidad",
            "Precio",
            "Forma de pago"});
            this.cmbSelecc.Location = new System.Drawing.Point(103, 40);
            this.cmbSelecc.Name = "cmbSelecc";
            this.cmbSelecc.Size = new System.Drawing.Size(121, 26);
            this.cmbSelecc.TabIndex = 20;
            // 
            // txtModi
            // 
            this.txtModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModi.Location = new System.Drawing.Point(19, 135);
            this.txtModi.Name = "txtModi";
            this.txtModi.Size = new System.Drawing.Size(197, 22);
            this.txtModi.TabIndex = 21;
            this.txtModi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModi_KeyPress);
            // 
            // dtpModi
            // 
            this.dtpModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModi.Location = new System.Drawing.Point(19, 135);
            this.dtpModi.Name = "dtpModi";
            this.dtpModi.Size = new System.Drawing.Size(197, 22);
            this.dtpModi.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(12, 72);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 29);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // toti
            // 
            this.toti.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // cmbPago
            // 
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta débito",
            "Tarjeta crédito",
            "Transferencia",
            "Otro"});
            this.cmbPago.Location = new System.Drawing.Point(19, 107);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(197, 21);
            this.cmbPago.TabIndex = 24;
            this.cmbPago.Visible = false;
            this.cmbPago.SelectedIndexChanged += new System.EventHandler(this.cmbPago_SelectedIndexChanged);
            // 
            // DialogBoxModicaaarrrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 206);
            this.Controls.Add(this.cmbPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtModi);
            this.Controls.Add(this.dtpModi);
            this.Controls.Add(this.cmbSelecc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBoxModicaaarrrr";
            this.Text = "Modificar venta";
            this.Load += new System.EventHandler(this.DialogBoxModicaaarrrr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelecc;
        private System.Windows.Forms.TextBox txtModi;
        private System.Windows.Forms.DateTimePicker dtpModi;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip toti;
        private System.Windows.Forms.ComboBox cmbPago;
    }
}