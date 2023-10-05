namespace COMPLETE_FLAT_UI.Ventanas
{
    partial class VentanaDietas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDietas));
            this.dgvDieta = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.button_WOCGuardar = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.button_WOCCancelar = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.button_WOCEliminar = new COMPLETE_FLAT_UI.Clases.Button_WOC();
            this.txtPlaceHolderId = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDieta
            // 
            this.dgvDieta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDieta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieta.Location = new System.Drawing.Point(28, 64);
            this.dgvDieta.Name = "dgvDieta";
            this.dgvDieta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDieta.Size = new System.Drawing.Size(820, 512);
            this.dgvDieta.TabIndex = 1;
            this.dgvDieta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGridView1_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(25, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(99, 18);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Buscar Dieta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(38)))), ((int)(((byte)(73)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 648);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(855, 1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(34, 33);
            this.btncerrar.TabIndex = 11;
            this.btncerrar.Text = " ";
            this.toolTip1.SetToolTip(this.btncerrar, "Cerrar");
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            this.btncerrar.MouseEnter += new System.EventHandler(this.Btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.Btncerrar_MouseLeave);
            // 
            // button_WOCGuardar
            // 
            this.button_WOCGuardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCGuardar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCGuardar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.button_WOCGuardar.FlatAppearance.BorderSize = 0;
            this.button_WOCGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCGuardar.Location = new System.Drawing.Point(37, 593);
            this.button_WOCGuardar.Name = "button_WOCGuardar";
            this.button_WOCGuardar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCGuardar.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCGuardar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCGuardar.Size = new System.Drawing.Size(143, 41);
            this.button_WOCGuardar.TabIndex = 12;
            this.button_WOCGuardar.Text = "Guardar";
            this.button_WOCGuardar.TextColor = System.Drawing.Color.White;
            this.button_WOCGuardar.UseVisualStyleBackColor = false;
            this.button_WOCGuardar.Click += new System.EventHandler(this.Button_WOCGuardar_Click);
            // 
            // button_WOCCancelar
            // 
            this.button_WOCCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCCancelar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCCancelar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.button_WOCCancelar.FlatAppearance.BorderSize = 0;
            this.button_WOCCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCCancelar.Location = new System.Drawing.Point(237, 593);
            this.button_WOCCancelar.Name = "button_WOCCancelar";
            this.button_WOCCancelar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCCancelar.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCCancelar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCCancelar.Size = new System.Drawing.Size(143, 41);
            this.button_WOCCancelar.TabIndex = 13;
            this.button_WOCCancelar.Text = "Cancelar";
            this.button_WOCCancelar.TextColor = System.Drawing.Color.White;
            this.button_WOCCancelar.UseVisualStyleBackColor = false;
            this.button_WOCCancelar.Click += new System.EventHandler(this.Button_WOCCancelar_Click);
            // 
            // button_WOCEliminar
            // 
            this.button_WOCEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCEliminar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCEliminar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.button_WOCEliminar.FlatAppearance.BorderSize = 0;
            this.button_WOCEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCEliminar.Location = new System.Drawing.Point(435, 590);
            this.button_WOCEliminar.Name = "button_WOCEliminar";
            this.button_WOCEliminar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCEliminar.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.button_WOCEliminar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(51)))));
            this.button_WOCEliminar.Size = new System.Drawing.Size(143, 41);
            this.button_WOCEliminar.TabIndex = 14;
            this.button_WOCEliminar.Text = "Eliminar";
            this.button_WOCEliminar.TextColor = System.Drawing.Color.White;
            this.button_WOCEliminar.UseVisualStyleBackColor = false;
            // 
            // txtPlaceHolderId
            // 
            this.txtPlaceHolderId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderId.Location = new System.Drawing.Point(28, 30);
            this.txtPlaceHolderId.Name = "txtPlaceHolderId";
            this.txtPlaceHolderId.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderId.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderId.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderId.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderId.PlaceHolderText = "Ingrese el número de dieta a Buscar..";
            this.txtPlaceHolderId.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderId.Size = new System.Drawing.Size(296, 25);
            this.txtPlaceHolderId.TabIndex = 15;
            this.txtPlaceHolderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlaceHolderId_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // VentanaDietas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(890, 640);
            this.Controls.Add(this.txtPlaceHolderId);
            this.Controls.Add(this.button_WOCEliminar);
            this.Controls.Add(this.button_WOCCancelar);
            this.Controls.Add(this.button_WOCGuardar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvDieta);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaDietas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR DIETAS";
            this.Load += new System.EventHandler(this.VentanaDietas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaDietas_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDieta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncerrar;
        private Clases.Button_WOC button_WOCGuardar;
        private Clases.Button_WOC button_WOCCancelar;
        private Clases.Button_WOC button_WOCEliminar;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderId;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}