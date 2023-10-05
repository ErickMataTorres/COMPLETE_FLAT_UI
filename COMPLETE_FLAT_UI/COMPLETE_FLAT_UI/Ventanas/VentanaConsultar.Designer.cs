namespace COMPLETE_FLAT_UI.Ventanas
{
    partial class VentanaConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultar));
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btncerrar = new System.Windows.Forms.Button();
            this.button_WOCConsultar = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.button_WOCNueva = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.txtPlaceHolderBuscar = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsultas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 60);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(1087, 409);
            this.dgvConsultas.TabIndex = 2;
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultas_CellContentClick);
            this.dgvConsultas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvConsultas_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-216, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1373, 545);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Snow;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1076, -1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(36, 39);
            this.btncerrar.TabIndex = 83;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            this.btncerrar.MouseEnter += new System.EventHandler(this.Btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.Btncerrar_MouseLeave);
            // 
            // button_WOCConsultar
            // 
            this.button_WOCConsultar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCConsultar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.button_WOCConsultar.FlatAppearance.BorderSize = 0;
            this.button_WOCConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCConsultar.Location = new System.Drawing.Point(345, 475);
            this.button_WOCConsultar.Name = "button_WOCConsultar";
            this.button_WOCConsultar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCConsultar.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCConsultar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCConsultar.Size = new System.Drawing.Size(143, 41);
            this.button_WOCConsultar.TabIndex = 84;
            this.button_WOCConsultar.Text = "  Consultar Paciente";
            this.button_WOCConsultar.TextColor = System.Drawing.Color.White;
            this.button_WOCConsultar.UseVisualStyleBackColor = true;
            this.button_WOCConsultar.Click += new System.EventHandler(this.Button_WOCConsultar_Click);
            // 
            // button_WOCNueva
            // 
            this.button_WOCNueva.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCNueva.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCNueva.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.button_WOCNueva.FlatAppearance.BorderSize = 0;
            this.button_WOCNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCNueva.Location = new System.Drawing.Point(12, 475);
            this.button_WOCNueva.Name = "button_WOCNueva";
            this.button_WOCNueva.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCNueva.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCNueva.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCNueva.Size = new System.Drawing.Size(143, 41);
            this.button_WOCNueva.TabIndex = 81;
            this.button_WOCNueva.Text = "   Nueva consulta";
            this.button_WOCNueva.TextColor = System.Drawing.Color.White;
            this.button_WOCNueva.UseVisualStyleBackColor = false;
            this.button_WOCNueva.Click += new System.EventHandler(this.Button_WOCNueva_Click);
            // 
            // txtPlaceHolderBuscar
            // 
            this.txtPlaceHolderBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderBuscar.Location = new System.Drawing.Point(12, 29);
            this.txtPlaceHolderBuscar.Name = "txtPlaceHolderBuscar";
            this.txtPlaceHolderBuscar.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderBuscar.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderBuscar.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderBuscar.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderBuscar.PlaceHolderText = "Buscar paciente por sus nombre(s) apellido(s)";
            this.txtPlaceHolderBuscar.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderBuscar.Size = new System.Drawing.Size(464, 25);
            this.txtPlaceHolderBuscar.TabIndex = 2;
            this.txtPlaceHolderBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlaceHolderBuscar_KeyPress);
            // 
            // VentanaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1111, 544);
            this.Controls.Add(this.button_WOCConsultar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.button_WOCNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaceHolderBuscar);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR PACIENTE";
            this.Load += new System.EventHandler(this.VentanaConsultar_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaConsultar_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsultas;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Clases.Button_WOC button_WOCNueva;
        private System.Windows.Forms.Button btncerrar;
        private Clases.Button_WOC button_WOCConsultar;
    }
}