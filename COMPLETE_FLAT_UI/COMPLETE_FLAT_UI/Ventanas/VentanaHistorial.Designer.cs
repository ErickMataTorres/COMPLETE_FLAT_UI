namespace COMPLETE_FLAT_UI.Ventanas
{
    partial class VentanaHistorial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaHistorial));
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblDiferencias = new System.Windows.Forms.Label();
            this.lblBrazo = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblCintura = new System.Windows.Forms.Label();
            this.lblCadera = new System.Windows.Forms.Label();
            this.lblBusto = new System.Windows.Forms.Label();
            this.lblEstomago = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPlaceHolderEstomago = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderBusto = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderCadera = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderCintura = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderBrazo = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderPeso = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            this.txtPlaceHolderId = new FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(873, 37);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(285, 25);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.DtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(532, 35);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(284, 25);
            this.dtpDesde.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHasta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(870, 16);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDesde.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(531, 16);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(47, 16);
            this.lblDesde.TabIndex = 12;
            this.lblDesde.Text = "Desde";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.SteelBlue;
            this.lblId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(9, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(243, 18);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Calcular Parámetros del Paciente";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.Color.White;
            this.dgvHistorial.Location = new System.Drawing.Point(7, 94);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1289, 430);
            this.dgvHistorial.TabIndex = 4;
            this.dgvHistorial.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvHistorial_DataBindingComplete);
            // 
            // lblDiferencias
            // 
            this.lblDiferencias.AutoSize = true;
            this.lblDiferencias.BackColor = System.Drawing.Color.Transparent;
            this.lblDiferencias.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencias.ForeColor = System.Drawing.Color.White;
            this.lblDiferencias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDiferencias.Location = new System.Drawing.Point(305, 527);
            this.lblDiferencias.Name = "lblDiferencias";
            this.lblDiferencias.Size = new System.Drawing.Size(583, 41);
            this.lblDiferencias.TabIndex = 14;
            this.lblDiferencias.Text = "COMPARACIÓN DE PARÁMETROS";
            this.lblDiferencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblDiferencias, "COMPARACION DE PARAMETROS");
            // 
            // lblBrazo
            // 
            this.lblBrazo.AutoSize = true;
            this.lblBrazo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrazo.ForeColor = System.Drawing.Color.White;
            this.lblBrazo.Location = new System.Drawing.Point(192, 575);
            this.lblBrazo.Name = "lblBrazo";
            this.lblBrazo.Size = new System.Drawing.Size(50, 18);
            this.lblBrazo.TabIndex = 14;
            this.lblBrazo.Text = "Brazo";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(12, 575);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(44, 18);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "Peso";
            // 
            // lblCintura
            // 
            this.lblCintura.AutoSize = true;
            this.lblCintura.BackColor = System.Drawing.Color.Transparent;
            this.lblCintura.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCintura.ForeColor = System.Drawing.Color.White;
            this.lblCintura.Location = new System.Drawing.Point(397, 573);
            this.lblCintura.Name = "lblCintura";
            this.lblCintura.Size = new System.Drawing.Size(60, 18);
            this.lblCintura.TabIndex = 14;
            this.lblCintura.Text = "Cintura";
            // 
            // lblCadera
            // 
            this.lblCadera.AutoSize = true;
            this.lblCadera.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadera.ForeColor = System.Drawing.Color.White;
            this.lblCadera.Location = new System.Drawing.Point(602, 575);
            this.lblCadera.Name = "lblCadera";
            this.lblCadera.Size = new System.Drawing.Size(59, 18);
            this.lblCadera.TabIndex = 14;
            this.lblCadera.Text = "Cadera";
            // 
            // lblBusto
            // 
            this.lblBusto.AutoSize = true;
            this.lblBusto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusto.ForeColor = System.Drawing.Color.White;
            this.lblBusto.Location = new System.Drawing.Point(797, 575);
            this.lblBusto.Name = "lblBusto";
            this.lblBusto.Size = new System.Drawing.Size(50, 18);
            this.lblBusto.TabIndex = 14;
            this.lblBusto.Text = "Busto";
            // 
            // lblEstomago
            // 
            this.lblEstomago.AutoSize = true;
            this.lblEstomago.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstomago.ForeColor = System.Drawing.Color.White;
            this.lblEstomago.Location = new System.Drawing.Point(1000, 573);
            this.lblEstomago.Name = "lblEstomago";
            this.lblEstomago.Size = new System.Drawing.Size(78, 18);
            this.lblEstomago.TabIndex = 14;
            this.lblEstomago.Text = "Estómago";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1221, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1272, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(34, 34);
            this.btncerrar.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btncerrar, "Cerrar");
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            this.btncerrar.MouseEnter += new System.EventHandler(this.Btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.Btncerrar_MouseLeave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(392, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 72);
            this.btnBuscar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnBuscar, "BUSCAR NOMBRE DEL PACIENTE PARA SER CALCULADO");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.BtnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.BtnBuscar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1319, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtPlaceHolderEstomago
            // 
            this.txtPlaceHolderEstomago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderEstomago.Location = new System.Drawing.Point(1003, 596);
            this.txtPlaceHolderEstomago.Name = "txtPlaceHolderEstomago";
            this.txtPlaceHolderEstomago.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderEstomago.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderEstomago.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderEstomago.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderEstomago.PlaceHolderText = "estómago a calcular";
            this.txtPlaceHolderEstomago.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderEstomago.Size = new System.Drawing.Size(170, 25);
            this.txtPlaceHolderEstomago.TabIndex = 25;
            // 
            // txtPlaceHolderBusto
            // 
            this.txtPlaceHolderBusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderBusto.Location = new System.Drawing.Point(800, 596);
            this.txtPlaceHolderBusto.Name = "txtPlaceHolderBusto";
            this.txtPlaceHolderBusto.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderBusto.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderBusto.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderBusto.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderBusto.PlaceHolderText = "busto a calcular";
            this.txtPlaceHolderBusto.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderBusto.Size = new System.Drawing.Size(189, 25);
            this.txtPlaceHolderBusto.TabIndex = 24;
            // 
            // txtPlaceHolderCadera
            // 
            this.txtPlaceHolderCadera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderCadera.Location = new System.Drawing.Point(605, 596);
            this.txtPlaceHolderCadera.Name = "txtPlaceHolderCadera";
            this.txtPlaceHolderCadera.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderCadera.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderCadera.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderCadera.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderCadera.PlaceHolderText = "cadera calcular";
            this.txtPlaceHolderCadera.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderCadera.Size = new System.Drawing.Size(172, 25);
            this.txtPlaceHolderCadera.TabIndex = 23;
            // 
            // txtPlaceHolderCintura
            // 
            this.txtPlaceHolderCintura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderCintura.Location = new System.Drawing.Point(400, 596);
            this.txtPlaceHolderCintura.Name = "txtPlaceHolderCintura";
            this.txtPlaceHolderCintura.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderCintura.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderCintura.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderCintura.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderCintura.PlaceHolderText = "cintura a calular";
            this.txtPlaceHolderCintura.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderCintura.Size = new System.Drawing.Size(182, 25);
            this.txtPlaceHolderCintura.TabIndex = 22;
            // 
            // txtPlaceHolderBrazo
            // 
            this.txtPlaceHolderBrazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderBrazo.Location = new System.Drawing.Point(195, 596);
            this.txtPlaceHolderBrazo.Name = "txtPlaceHolderBrazo";
            this.txtPlaceHolderBrazo.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderBrazo.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderBrazo.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderBrazo.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderBrazo.PlaceHolderText = "medida a calcular";
            this.txtPlaceHolderBrazo.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderBrazo.Size = new System.Drawing.Size(191, 25);
            this.txtPlaceHolderBrazo.TabIndex = 20;
            // 
            // txtPlaceHolderPeso
            // 
            this.txtPlaceHolderPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderPeso.Location = new System.Drawing.Point(12, 596);
            this.txtPlaceHolderPeso.Name = "txtPlaceHolderPeso";
            this.txtPlaceHolderPeso.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderPeso.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderPeso.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderPeso.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderPeso.PlaceHolderText = "peso a calcular";
            this.txtPlaceHolderPeso.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderPeso.Size = new System.Drawing.Size(177, 25);
            this.txtPlaceHolderPeso.TabIndex = 19;
            // 
            // txtPlaceHolderId
            // 
            this.txtPlaceHolderId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaceHolderId.Location = new System.Drawing.Point(7, 37);
            this.txtPlaceHolderId.Name = "txtPlaceHolderId";
            this.txtPlaceHolderId.PlaceHolderDescriptionToolTip = "Campo requerido.";
            this.txtPlaceHolderId.PlaceHolderFieldRequired = false;
            this.txtPlaceHolderId.PlaceHolderFieldRequiredFocused = false;
            this.txtPlaceHolderId.PlaceHolderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceHolderId.PlaceHolderText = "Ingresar Nombre Completo del Paciente a Calcular";
            this.txtPlaceHolderId.PlaceHolderTitleToolTip = "¡Atención!";
            this.txtPlaceHolderId.Size = new System.Drawing.Size(379, 25);
            this.txtPlaceHolderId.TabIndex = 18;
            this.txtPlaceHolderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlaceHolderId_KeyPress);
            // 
            // VentanaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1308, 659);
            this.Controls.Add(this.txtPlaceHolderEstomago);
            this.Controls.Add(this.txtPlaceHolderBusto);
            this.Controls.Add(this.txtPlaceHolderCadera);
            this.Controls.Add(this.txtPlaceHolderCintura);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txtPlaceHolderBrazo);
            this.Controls.Add(this.txtPlaceHolderPeso);
            this.Controls.Add(this.txtPlaceHolderId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEstomago);
            this.Controls.Add(this.lblBusto);
            this.Controls.Add(this.lblCadera);
            this.Controls.Add(this.lblCintura);
            this.Controls.Add(this.lblBrazo);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDiferencias);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORIAL DEL PACIENTE";
            this.Load += new System.EventHandler(this.VentanaHistorial_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaHistorial_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblDiferencias;
        private System.Windows.Forms.Label lblBrazo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblCintura;
        private System.Windows.Forms.Label lblCadera;
        private System.Windows.Forms.Label lblBusto;
        private System.Windows.Forms.Label lblEstomago;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderId;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderPeso;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderBrazo;
        private System.Windows.Forms.Button btncerrar;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderCintura;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderCadera;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderBusto;
        private FuncionesGeneralesCs.ControlesPersonalizados.TxtPlaceHolder txtPlaceHolderEstomago;
    }
}