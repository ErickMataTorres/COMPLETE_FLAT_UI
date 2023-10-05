namespace COMPLETE_FLAT_UI
{
    partial class VentanaReservarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaReservarCita));
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpCita = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btncerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_WOCEliminar = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.button_WOCCancelar = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.button_WOCReservar = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.txtPlaceHolderId = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderTelefono = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderNombre = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHora
            // 
            this.cbHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "7:00  ",
            "8:00 ",
            "9:00 ",
            "10:00 ",
            "11:00 ",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.cbHora.Location = new System.Drawing.Point(384, 46);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(124, 26);
            this.cbHora.TabIndex = 36;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.lblHora.Location = new System.Drawing.Point(381, 27);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 16);
            this.lblHora.TabIndex = 35;
            this.lblHora.Text = "Hora";
            // 
            // dtpCita
            // 
            this.dtpCita.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCita.Location = new System.Drawing.Point(40, 254);
            this.dtpCita.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCita.Name = "dtpCita";
            this.dtpCita.Size = new System.Drawing.Size(298, 21);
            this.dtpCita.TabIndex = 34;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(271, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 40);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnBuscar, "BUSCAR");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(503, -3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(47, 43);
            this.btncerrar.TabIndex = 38;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click_1);
            this.btncerrar.MouseEnter += new System.EventHandler(this.Btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.Btncerrar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombres y Apellidos del Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Teléfono del Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID del Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(40, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha Cita";
            // 
            // button_WOCEliminar
            // 
            this.button_WOCEliminar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCEliminar.ButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCEliminar.FlatAppearance.BorderSize = 0;
            this.button_WOCEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.button_WOCEliminar.Location = new System.Drawing.Point(384, 336);
            this.button_WOCEliminar.Name = "button_WOCEliminar";
            this.button_WOCEliminar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCEliminar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_WOCEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOCEliminar.Size = new System.Drawing.Size(140, 33);
            this.button_WOCEliminar.TabIndex = 51;
            this.button_WOCEliminar.Text = "Eliminar";
            this.button_WOCEliminar.TextColor = System.Drawing.Color.Black;
            this.button_WOCEliminar.UseVisualStyleBackColor = true;
            this.button_WOCEliminar.Click += new System.EventHandler(this.Button_WOCEliminar_Click);
            // 
            // button_WOCCancelar
            // 
            this.button_WOCCancelar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCCancelar.ButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCCancelar.FlatAppearance.BorderSize = 0;
            this.button_WOCCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.button_WOCCancelar.Location = new System.Drawing.Point(203, 336);
            this.button_WOCCancelar.Name = "button_WOCCancelar";
            this.button_WOCCancelar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCCancelar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_WOCCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOCCancelar.Size = new System.Drawing.Size(140, 33);
            this.button_WOCCancelar.TabIndex = 50;
            this.button_WOCCancelar.Text = "Cancelar";
            this.button_WOCCancelar.TextColor = System.Drawing.Color.Black;
            this.button_WOCCancelar.UseVisualStyleBackColor = true;
            this.button_WOCCancelar.Click += new System.EventHandler(this.Button_WOCCancelar_Click);
            // 
            // button_WOCReservar
            // 
            this.button_WOCReservar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCReservar.ButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCReservar.FlatAppearance.BorderSize = 0;
            this.button_WOCReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCReservar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_WOCReservar.Location = new System.Drawing.Point(24, 336);
            this.button_WOCReservar.Name = "button_WOCReservar";
            this.button_WOCReservar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCReservar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.button_WOCReservar.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOCReservar.Size = new System.Drawing.Size(140, 33);
            this.button_WOCReservar.TabIndex = 49;
            this.button_WOCReservar.Text = "Guardar Cita";
            this.button_WOCReservar.TextColor = System.Drawing.Color.Black;
            this.button_WOCReservar.UseVisualStyleBackColor = true;
            this.button_WOCReservar.Click += new System.EventHandler(this.Button_WOCReservar_Click);
            // 
            // txtPlaceHolderId
            // 
            this.txtPlaceHolderId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderId.Location = new System.Drawing.Point(40, 41);
            this.txtPlaceHolderId.Name = "txtPlaceHolderId";
            this.txtPlaceHolderId.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderId.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderId.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderId.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderId.PlaceHolderText = "ID Paciente";
            this.txtPlaceHolderId.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderId.Size = new System.Drawing.Size(224, 25);
            this.txtPlaceHolderId.TabIndex = 46;
            this.txtPlaceHolderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlaceHolderId_KeyPress);
            // 
            // txtPlaceHolderTelefono
            // 
            this.txtPlaceHolderTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderTelefono.Location = new System.Drawing.Point(40, 180);
            this.txtPlaceHolderTelefono.Name = "txtPlaceHolderTelefono";
            this.txtPlaceHolderTelefono.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderTelefono.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderTelefono.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderTelefono.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderTelefono.PlaceHolderText = "Número del Paciente";
            this.txtPlaceHolderTelefono.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderTelefono.Size = new System.Drawing.Size(298, 25);
            this.txtPlaceHolderTelefono.TabIndex = 45;
            // 
            // txtPlaceHolderNombre
            // 
            this.txtPlaceHolderNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderNombre.Location = new System.Drawing.Point(40, 109);
            this.txtPlaceHolderNombre.Name = "txtPlaceHolderNombre";
            this.txtPlaceHolderNombre.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderNombre.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderNombre.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderNombre.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderNombre.PlaceHolderText = "Nombre(s) Apellido(s)";
            this.txtPlaceHolderNombre.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderNombre.Size = new System.Drawing.Size(298, 25);
            this.txtPlaceHolderNombre.TabIndex = 43;
            // 
            // VentanaReservarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(552, 422);
            this.Controls.Add(this.button_WOCEliminar);
            this.Controls.Add(this.button_WOCCancelar);
            this.Controls.Add(this.button_WOCReservar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaceHolderId);
            this.Controls.Add(this.txtPlaceHolderTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaceHolderNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.dtpCita);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaReservarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CITAS";
            this.Load += new System.EventHandler(this.VentanaReservarCita_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaReservarCita_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpCita;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderNombre;
        private System.Windows.Forms.Label label3;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderTelefono;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Clases.Button_WOC button_WOCReservar;
        private Clases.Button_WOC button_WOCCancelar;
        private Clases.Button_WOC button_WOCEliminar;
    }
}