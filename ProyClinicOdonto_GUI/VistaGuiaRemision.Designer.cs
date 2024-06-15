namespace ProyClinicOdonto_GUI
{
    partial class VistaGuiaRemision
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
            lblRegistros = new Label();
            label2 = new Label();
            dtgGuia = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgGuia).BeginInit();
            SuspendLayout();
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistros.Location = new Point(1574, 731);
            lblRegistros.Margin = new Padding(5, 0, 5, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(106, 41);
            lblRegistros.TabIndex = 13;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(1399, 735);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 34);
            label2.TabIndex = 15;
            label2.Text = "Registros:";
            // 
            // dtgGuia
            // 
            dtgGuia.AllowUserToAddRows = false;
            dtgGuia.AllowUserToDeleteRows = false;
            dtgGuia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgGuia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgGuia.BackgroundColor = SystemColors.ActiveCaption;
            dtgGuia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGuia.GridColor = SystemColors.ActiveCaptionText;
            dtgGuia.Location = new Point(75, 84);
            dtgGuia.Margin = new Padding(5);
            dtgGuia.Name = "dtgGuia";
            dtgGuia.ReadOnly = true;
            dtgGuia.RowHeadersVisible = false;
            dtgGuia.RowHeadersWidth = 51;
            dtgGuia.RowTemplate.Height = 29;
            dtgGuia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgGuia.Size = new Size(1605, 631);
            dtgGuia.TabIndex = 14;
            dtgGuia.CellContentClick += dtgGuia_CellContentClick;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(490, 27);
            txtFiltro.Margin = new Padding(5);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(506, 31);
            txtFiltro.TabIndex = 16;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(357, 28);
            label1.TabIndex = 17;
            label1.Text = "Ingrese el Nombre de Equipo:";
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(75, 735);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(162, 68);
            button2.TabIndex = 18;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            // 
            // VistaGuiaRemision
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1755, 856);
            Controls.Add(button2);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgGuia);
            Name = "VistaGuiaRemision";
            Text = "VistaGuiaRemision";
            Load += VistaGuiaRemision_Load;
            ((System.ComponentModel.ISupportInitialize)dtgGuia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgGuia;
        private TextBox txtFiltro;
        private Label label1;
        private Button button2;
    }
}