using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class VentanaReservarCita : Form
    {

        //estilo quita el encabezado del formuloario
        //===========================================
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect, // x-coordinate of upper-left corner
                 int nTopRect, // y-coordinate of upper-left corner
                 int nRightRect, // x-coordinate of lower-right corner
                 int nBottomRect, // y-coordinate of lower-right corner
                 int nWidthEllipse, // height of ellipse
                 int nHeightEllipse // width of ellipse
              );

        //===========================================
        public VentanaReservarCita()
        {
            InitializeComponent();

            //quitar encabezado del formulario
            //=========================================================================================
            //this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //=========================================================================================

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ventanas.VentanaBuscar ventana = new Ventanas.VentanaBuscar();
            string resultado = ventana.Busca("TablaReservarCita", "Id, Nombre", "Nombre", "Id", "Citas");
            if (resultado != "")
            {
                txtPlaceHolderId.Text = resultado;
                KeyPressEventArgs tecla = new KeyPressEventArgs((char)Keys.Enter);
                TxtPlaceHolderId_KeyPress(sender, tecla);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaReservarCita_Load(object sender, EventArgs e)
        {
            Activar(true);
        }
        private void Activar(bool activo)
        {
            txtPlaceHolderId.Enabled = activo;
            txtPlaceHolderNombre.Enabled = !activo;
            txtPlaceHolderTelefono.Enabled = !activo;
            dtpCita.Enabled = !activo;
            cbHora.Enabled = !activo;
            button_WOCReservar.Enabled = !activo;
            button_WOCCancelar.Enabled = !activo;
            button_WOCEliminar.Enabled = !activo;
            if (activo)
            {
                txtPlaceHolderNombre.Clear();
                txtPlaceHolderTelefono.Clear();
                //dtpFechaNacimiento.Text = null;
                //txtEdad.Clear();
                //txtEnfermedad.Clear();
                //txtAntecedentes.Clear();
                //txtMedicamento.Clear();
                //txtDiagnostico.Clear();
                //txtActividad.Clear();
                dtpCita.Text = null;
                cbHora.Text = null;
                txtPlaceHolderId.Text = Clases.ReservarCita.MaximoId().ToString();
                txtPlaceHolderId.Focus();
            }
            else
            {
                txtPlaceHolderNombre.Focus();

            }


            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaReservarCita_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaReservarCita_MouseMove);
            //======================================================================================================
            //fin mover el formulario
        }
        // función privada usada para mover el formulario actual 
        //===================================================================================================
        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;


        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }
        private void VentanaReservarCita_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }
        //====================================================================================================
        // fin función para mover el formulario actual
        private void BtnReservar_Click(object sender, EventArgs e)
        {
            //Clases.ReservarCita c = new Clases.ReservarCita();
            //c.Id = int.Parse(txtPlaceHolderId.Text.Trim());
            //c.Nombre = txtPlaceHolderNombre.Text.ToUpper().Trim();
            //c.Telefono = txtPlaceHolderTelefono.Text.Trim();
            ////c.Fecha_Nacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
            ////c.Edad = int.Parse(txtEdad.Text.Trim());
            ////c.Enfermedad = txtEnfermedad.Text.ToUpper().Trim();
            ////c.Antecedentes_Familiares = txtAntecedentes.Text.ToUpper().Trim();
            ////c.Medicamento = txtMedicamento.Text.ToUpper().Trim();
            ////c.Diagnostico = txtDiagnostico.Text.ToUpper().Trim();
            ////c.Actividad_Fisica = txtActividad.Text.ToUpper().Trim();
            //c.Cita = Convert.ToDateTime(dtpCita.Value);
            //c.Hora = cbHora.Text;

            //int respuesta = 0;
            //respuesta = Clases.ReservarCita.ValidaCita(dtpCita.Value, cbHora.Text);
            //if (respuesta == 1)
            //{
            //    MessageBox.Show("Ya esta reservada esa cita, por favor elegir otra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    return;
            //}



            //c.MetodoReservarCita();
            //if (c.MetodoReservarCita() == "ok")
            //{
            //    MessageBox.Show("Se ha reservado la cita satisfactoriamente para:\nPara el día: " + dtpCita.Value.ToShortDateString()+"\nHora: "+cbHora.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    Activar(true);
            //}
            //else
            //{
            //    MessageBox.Show(c.MetodoReservarCita(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Esta seguro que quisiera eliminar la cita?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
            //    Clases.ReservarCita c = new Clases.ReservarCita();
            //    c.EliminarCita(int.Parse(txtPlaceHolderId.Text.Trim()));
            //    Activar(true);
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Cancelar la cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
            //    Activar(true);
            //}
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    if (txtId.Text == "")
            //    {
            //        return;
            //    }
            //    Activar(false);
            //    Clases.ReservarCita c;
            //    c = Clases.ReservarCita.Cargar(int.Parse(txtId.Text.Trim()));
            //    if (c.Id == int.Parse(txtId.Text.Trim()))
            //    {
            //        txtPlaceHolderNombre.Text = c.Nombre;
            //        txtPlaceHolderTelefono.Text = c.Telefono;
            //        //dtpFechaNacimiento.Text = c.Fecha_Nacimiento.ToString();
            //        //txtEdad.Text = c.Edad.ToString();
            //        //txtEnfermedad.Text = c.Enfermedad;
            //        //txtAntecedentes.Text = c.Antecedentes_Familiares;
            //        //txtMedicamento.Text = c.Medicamento;
            //        //txtDiagnostico.Text = c.Diagnostico;
            //        //txtActividad.Text = c.Actividad_Fisica;
            //        dtpCita.Text = c.Cita.ToString();
            //        cbHora.Text = c.Hora;
            //        btnEliminar.Enabled = true;
            //    }
            //}
        }

        private void Btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPlaceHolderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPlaceHolderId.Text == "")
                {
                    return;
                }
                Activar(false);
                Clases.ReservarCita c;
                c = Clases.ReservarCita.Cargar(int.Parse(txtPlaceHolderId.Text.Trim()));
                if (c.Id == int.Parse(txtPlaceHolderId.Text.Trim()))
                {
                    txtPlaceHolderNombre.Text = c.Nombre;
                    txtPlaceHolderTelefono.Text = c.Telefono;
                    //dtpFechaNacimiento.Text = c.Fecha_Nacimiento.ToString();
                    //txtEdad.Text = c.Edad.ToString();
                    //txtEnfermedad.Text = c.Enfermedad;
                    //txtAntecedentes.Text = c.Antecedentes_Familiares;
                    //txtMedicamento.Text = c.Medicamento;
                    //txtDiagnostico.Text = c.Diagnostico;
                    //txtActividad.Text = c.Actividad_Fisica;
                    dtpCita.Text = c.Cita.ToString();
                    cbHora.Text = c.Hora;
                    button_WOCEliminar.Enabled = true;
                }
            }
        }

        private void Button_WOCReservar_Click(object sender, EventArgs e)
        {
            Clases.ReservarCita c = new Clases.ReservarCita();
            c.Id = int.Parse(txtPlaceHolderId.Text.Trim());
            c.Nombre = txtPlaceHolderNombre.Text.ToUpper().Trim();
            c.Telefono = txtPlaceHolderTelefono.Text.Trim();
            //c.Fecha_Nacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
            //c.Edad = int.Parse(txtEdad.Text.Trim());
            //c.Enfermedad = txtEnfermedad.Text.ToUpper().Trim();
            //c.Antecedentes_Familiares = txtAntecedentes.Text.ToUpper().Trim();
            //c.Medicamento = txtMedicamento.Text.ToUpper().Trim();
            //c.Diagnostico = txtDiagnostico.Text.ToUpper().Trim();
            //c.Actividad_Fisica = txtActividad.Text.ToUpper().Trim();
            c.Cita = Convert.ToDateTime(dtpCita.Value);
            c.Hora = cbHora.Text;

            int respuesta = 0;
            respuesta = Clases.ReservarCita.ValidaCita(dtpCita.Value, cbHora.Text);
            if (respuesta == 1)
            {
                MessageBox.Show("Ya esta reservada esa cita, por favor elegir otra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }



            c.MetodoReservarCita();
            if (c.MetodoReservarCita() == "ok")
            {
                MessageBox.Show("Se ha reservado la cita satisfactoriamente para:\nPara el día: " + dtpCita.Value.ToShortDateString() + "\nHora: " + cbHora.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Activar(true);
            }
            else
            {
                MessageBox.Show(c.MetodoReservarCita(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Button_WOCCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar la cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Activar(true);
            }
        }

        private void Button_WOCEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quisiera eliminar la cita?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Clases.ReservarCita c = new Clases.ReservarCita();
                c.EliminarCita(int.Parse(txtPlaceHolderId.Text.Trim()));
                Activar(true);
            }
        }

        private void Btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.oscuroclose;
        }

        private void Btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.closeclaro;
        }

        private void BtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.Image = Properties.Resources.buscaroscuro;
        }

        private void BtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.Image = Properties.Resources.buscarazul;
        }
    }
}
