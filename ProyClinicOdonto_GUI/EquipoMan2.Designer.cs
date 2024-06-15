namespace ProyClinicOdonto_GUI
{
    partial class EquipoMan2
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
            grpDatos = new GroupBox();
            txtTelefono = new TextBox();
            label12 = new Label();
            txtRuc = new TextBox();
            label11 = new Label();
            txtProveedor = new TextBox();
            label10 = new Label();
            dtpFecLPartida = new DateTimePicker();
            label8 = new Label();
            mskStock = new MaskedTextBox();
            cboPiso = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            chkActivo = new CheckBox();
            mskCantidad = new MaskedTextBox();
            label4 = new Label();
            cboTipo = new ComboBox();
            label3 = new Label();
            txtDesc = new TextBox();
            dtpFechaReg = new DateTimePicker();
            txtNomEqui = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(txtRuc);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(txtProveedor);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(dtpFecLPartida);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(mskStock);
            grpDatos.Controls.Add(cboPiso);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(mskCantidad);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(cboTipo);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtDesc);
            grpDatos.Controls.Add(dtpFechaReg);
            grpDatos.Controls.Add(txtNomEqui);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(29, 28);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(842, 784);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(254, 485);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(278, 33);
            txtTelefono.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(50, 485);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(103, 25);
            label12.TabIndex = 35;
            label12.Text = "Telefono:";
            // 
            // txtRuc
            // 
            txtRuc.Cursor = Cursors.IBeam;
            txtRuc.Location = new Point(254, 404);
            txtRuc.Margin = new Padding(4);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(278, 33);
            txtRuc.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(56, 412);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(56, 25);
            label11.TabIndex = 33;
            label11.Text = "Ruc:";
            // 
            // txtProveedor
            // 
            txtProveedor.Cursor = Cursors.IBeam;
            txtProveedor.Location = new Point(254, 338);
            txtProveedor.Margin = new Padding(4);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(278, 33);
            txtProveedor.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 338);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(122, 25);
            label10.TabIndex = 31;
            label10.Text = "Proveedor:";
            // 
            // dtpFecLPartida
            // 
            dtpFecLPartida.Location = new Point(257, 602);
            dtpFecLPartida.Name = "dtpFecLPartida";
            dtpFecLPartida.Size = new Size(401, 33);
            dtpFecLPartida.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 664);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(199, 25);
            label8.TabIndex = 29;
            label8.Text = "Fecha de llegada:";
            label8.Click += label8_Click;
            // 
            // mskStock
            // 
            mskStock.Location = new Point(257, 278);
            mskStock.Mask = "9999";
            mskStock.Name = "mskStock";
            mskStock.Size = new Size(81, 33);
            mskStock.TabIndex = 28;
            // 
            // cboPiso
            // 
            cboPiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPiso.FormattingEnabled = true;
            cboPiso.Items.AddRange(new object[] { "Quirurgico", "Asistencial", "Maquinaria", "Manual", "Rayos X", "Instrumento" });
            cboPiso.Location = new Point(257, 179);
            cboPiso.Name = "cboPiso";
            cboPiso.Size = new Size(192, 31);
            cboPiso.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 185);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 26;
            label7.Text = "Piso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 281);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 25;
            label5.Text = "Stock:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(257, 554);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(103, 29);
            chkActivo.TabIndex = 4;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.UseWaitCursor = true;
            // 
            // mskCantidad
            // 
            mskCantidad.Location = new Point(257, 228);
            mskCantidad.Mask = "9999";
            mskCantidad.Name = "mskCantidad";
            mskCantidad.Size = new Size(81, 33);
            mskCantidad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 558);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 24;
            label4.Text = "Estado:";
            label4.UseWaitCursor = true;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Quirurgico", "Asistencial", "Maquinaria", "Manual", "Rayos X", "Instrumento" });
            cboTipo.Location = new Point(257, 130);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(275, 31);
            cboTipo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 228);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 22;
            label3.Text = "Cantidad:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(257, 86);
            txtDesc.Margin = new Padding(4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(370, 33);
            txtDesc.TabIndex = 3;
            // 
            // dtpFechaReg
            // 
            dtpFechaReg.Location = new Point(257, 656);
            dtpFechaReg.Name = "dtpFechaReg";
            dtpFechaReg.Size = new Size(398, 33);
            dtpFechaReg.TabIndex = 6;
            // 
            // txtNomEqui
            // 
            txtNomEqui.Cursor = Cursors.IBeam;
            txtNomEqui.Location = new Point(257, 37);
            txtNomEqui.Margin = new Padding(4);
            txtNomEqui.Name = "txtNomEqui";
            txtNomEqui.Size = new Size(278, 33);
            txtNomEqui.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(690, 713);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(529, 713);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 609);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(194, 25);
            label9.TabIndex = 16;
            label9.Text = "Fecha de partida:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 86);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 10;
            label6.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Equipo:";
            // 
            // EquipoMan2
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(906, 839);
            Controls.Add(grpDatos);
            Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipoMan2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Equipo";
            Load += EquipoMan2_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txtDesc;
        private TextBox txtNomEqui;
        private Button btnCancelar;
        private Button btnGrabar;
        private DateTimePicker dtpFechaReg;
        private Label label9;
        private Label label3;
        private ComboBox cboTipo;
        private MaskedTextBox mskCantidad;
        private CheckBox chkActivo;
        private Label label4;
        private Label label5;
        private MaskedTextBox mskStock;
        private ComboBox cboPiso;
        private Label label7;
        private DateTimePicker dtpFecLPartida;
        private Label label8;
        private TextBox txtTelefono;
        private Label label12;
        private TextBox txtRuc;
        private Label label11;
        private TextBox txtProveedor;
        private Label label10;
    }
}