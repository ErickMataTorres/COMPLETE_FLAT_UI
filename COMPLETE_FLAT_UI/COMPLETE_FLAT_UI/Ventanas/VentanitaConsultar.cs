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
using FuncionesGeneralesCs;






namespace COMPLETE_FLAT_UI.Ventanas
{
    public partial class VentanitaConsultar : Form
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

        public VentanitaConsultar()
        {
            InitializeComponent();

            //quitar encabezado del formulario
            //=========================================================================================
            //this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //=========================================================================================
        }

        private void VentanitaConsultar_Load(object sender, EventArgs e)
        {
            cbDieta.DataSource = Clases.Dietas.Lista();
            cbDieta.DisplayMember = "IdDieta";
            cbDieta.ValueMember = "IdDieta";


            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanitaConsultar_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanitaConsultar_MouseMove);
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
        private void VentanitaConsultar_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        //====================================================================================================
        // función para mover el formulario actual 

        public void Nuevo()
        {
            txtPlaceHoldernombre.Clear();
            dtpFechaNacimiento.Text = null;
            txtPlaceHolderedad.Clear();
            txtPlaceHolderActividadfísica.Clear();
            txtPlaceHolderDiagnostico.Clear();
            txtPlaceHolderEstatura.Clear();
            txtPlaceHolderPeso.Clear();
            txtPlaceHolderBrazo.Clear();
            txtPlaceHolderCadera.Clear();
            txtPlaceHolderBusto.Clear();
            txtPlaceHolderEstomago.Clear();
            txtPlaceHolderComplexion.Clear();
            txtPlaceHolderComplexion.Clear();
            cbDieta.SelectedValue = null;
            txtPlaceHolderTratamiento.Clear();
            txtPlaceHoldernombre.Focus();
            this.ShowDialog();
        }

        //=========================================================================================================
        public void Modificar(int id)
        {
            //TxtPlaceHoldertxtIdPaciente = id.ToString();
            txtPlaceHolder2.Text = id.ToString();
            Clases.Consultar c;
            c = Clases.Consultar.Cargar(int.Parse(txtPlaceHolder2.Text.Trim()));
            txtPlaceHoldernombre.Text = c.NombrePaciente;
            dtpFechaNacimiento.Value = c.FechaNacimiento;
            txtPlaceHolderedad.Text = c.Edad.ToString();
            txtPlaceHolderActividadfísica.Text = c.ActividadFisica;
            txtPlaceHolderDiagnostico.Text = c.Diagnostico;
            txtPlaceHolderEstatura.Text = c.Estatura.ToString();
            txtPlaceHolderPeso.Text = c.Peso.ToString();
            txtPlaceHolderBrazo.Text = c.Brazo;
            txtPlaceHolderCintura.Text = c.Cintura;
            txtPlaceHolderCadera.Text = c.Cadera;
            txtPlaceHolderBusto.Text = c.Busto;
            txtPlaceHolderEstomago.Text = c.Estomago;
            txtPlaceHolderComplexion.Text = c.Complexion;
            cbDieta.SelectedValue = c.Dieta;
            txtPlaceHolderTratamiento.Text = c.Tratamiento;
            txtPlaceHolderIMC.Text = c.IMC;
            txtPlaceHoldernombre.Focus();
            this.ShowDialog();
        }

        //====================================================================================================
        private void CalcularIMC()
        {
            if (txtPlaceHolderEstatura.Text == string.Empty || txtPlaceHolderPeso.Text == string.Empty)
            {
                return;
            }
            double estatura = 0;
            double peso = 0;
            double IMC = 0;
            string estado = string.Empty;
            double.TryParse(txtPlaceHolderEstatura.Text, out estatura);
            double.TryParse(txtPlaceHolderPeso.Text, out peso);
            IMC = (peso / Math.Pow(estatura, 2));

            if (IMC < 18.5)
            {
                estado = "Peso bajo";
            }
            else
            {
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    estado = "Peso normal";
                }
                else
                {
                    if (IMC > 24.9 && IMC <= 29.9)
                    {
                        estado = "Sobrepeso";
                    }
                    else
                    {
                        if (IMC >= 30 && IMC <= 39.9)
                        {
                            estado = "Obesidad";
                        }
                        else
                        {
                            if (IMC >= 40)
                            {
                                estado = "Obesidad mórbida";
                            }
                        }
                    }
                }
            }

            txtPlaceHolderIMC.Text = IMC.ToString("N4") + " Estado: " + estado;
        }


        //==================================================================================================
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Clases.Consultar c = new Clases.Consultar();
            //c.IdPaciente = int.Parse(txtPlaceHolder2.Text.Trim());
            //c.NombrePaciente = txtPlaceHoldernombre.Text.ToUpper().Trim();
            //c.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
            //c.Edad = int.Parse(txtPlaceHolderedad.Text.Trim());
            //c.ActividadFisica = txtPlaceHolderActividadfísica.Text.ToUpper().Trim();
            //c.Diagnostico = txtPlaceHolderDiagnostico.Text.ToUpper().Trim();
            //c.Estatura = txtPlaceHolderEstatura.Text.Trim();
            //c.Peso = txtPlaceHolderPeso.Text.Trim();
            //c.Brazo = txtPlaceHolderBrazo.Text.Trim();
            //c.Cintura = txtPlaceHolderCintura.Text.Trim();
            //c.Cadera = txtPlaceHolderCadera.Text.Trim();
            //c.Busto = txtPlaceHolderBusto.Text.Trim();
            //c.Estomago = txtPlaceHolderEstomago.Text.Trim();
            //c.Complexion = txtPlaceHolderComplexion.Text.Trim();
            //c.Dieta = int.Parse(cbDieta.Text);
            //c.Tratamiento = txtPlaceHolderTratamiento.Text.ToUpper().Trim();
            //c.IMC = txtPlaceHolderIMC.Text.ToUpper().Trim();
            //if (c.Guardar() == "ok")
            //{
            //    MessageBox.Show("Se ha guardado la consulta satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show(c.Guardar(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void TxtEstatura_TextChanged(object sender, EventArgs e)
        {
            //CalcularIMC();
        }

        private void TxtPeso_TextChanged(object sender, EventArgs e)
        {
            //CalcularIMC();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Ventanas.VentanaBuscar ventana = new Ventanas.VentanaBuscar();
            string resultado = ventana.Busca("TablaCitas", "IdPaciente, Nombre", "Nombre", "IdPaciente", "Citas");
            if (resultado != "")
            {
                //txtPlaceHolder2 = resultado;
                txtPlaceHolder2.Text = resultado;
                KeyPressEventArgs tecla = new KeyPressEventArgs((char)Keys.Enter);
                TxtPlaceHolder2_KeyPress(sender, tecla);
                //TxtPlaceHoldertxtIdPaciente_KeyPress(sender, tecla);
            }
        }

       

 //=================================================================================================================

        private void TxtPlaceHolder2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPlaceHolder2.Text == string.Empty)
                {
                    return;
                }
                Clases.Consultar ca;
                ca = Clases.Consultar.Cargar(int.Parse(txtPlaceHolder2.Text));
                Clases.ReservarCita c;
                c = Clases.ReservarCita.Cargar(int.Parse(txtPlaceHolder2.Text));
                if (txtPlaceHolder2.Text == c.Id.ToString() && ca.Tratamiento == null)
                {
                    txtPlaceHoldernombre.Text = c.Nombre;
                    dtpFechaNacimiento.Value = c.Cita;
                    txtPlaceHolderedad.Text = string.Empty;
                    txtPlaceHolderActividadfísica.Text = string.Empty;
                    txtPlaceHolderDiagnostico.Text = string.Empty;
                    txtPlaceHolderEstatura.Text = string.Empty;
                    txtPlaceHolderPeso.Text = string.Empty;
                    txtPlaceHolderBrazo.Text = string.Empty;
                    txtPlaceHolderCintura.Text = string.Empty;
                    txtPlaceHolderCadera.Text = string.Empty;
                    txtPlaceHolderBusto.Text = string.Empty;
                    txtPlaceHolderEstomago.Text = string.Empty;
                    txtPlaceHolderComplexion.Text = string.Empty;
                    cbDieta.Text = null;
                    txtPlaceHolderTratamiento.Text = string.Empty;
                    txtPlaceHolderIMC.Text = string.Empty;
                    dtpFechaNacimiento.Focus();
                }
                else
                {
                    if (txtPlaceHolder2.Text == ca.IdPaciente.ToString())
                    {
                        txtPlaceHoldernombre.Text = ca.NombrePaciente;
                        dtpFechaNacimiento.Value = ca.FechaNacimiento;
                        txtPlaceHolderedad.Text = ca.Edad.ToString();
                        txtPlaceHolderActividadfísica.Text = ca.ActividadFisica;
                        txtPlaceHolderDiagnostico.Text = ca.Diagnostico;
                        txtPlaceHolderEstatura.Text = ca.Estatura;
                        txtPlaceHolderPeso.Text = ca.Peso;
                        txtPlaceHolderBrazo.Text = ca.Brazo;
                        txtPlaceHolderCintura.Text = ca.Cintura;
                        txtPlaceHolderCadera.Text = ca.Cadera;
                        txtPlaceHolderBusto.Text = ca.Busto;
                        txtPlaceHolderEstomago.Text = ca.Estomago;
                        txtPlaceHolderComplexion.Text = ca.Complexion;
                        cbDieta.SelectedValue = ca.Dieta;
                        txtPlaceHolderTratamiento.Text = ca.Tratamiento;
                        txtPlaceHolderIMC.Text = ca.IMC;
                        txtPlaceHoldernombre.Focus();
                    }
                    else
                    {
                        txtPlaceHoldernombre.Focus();
                    }
                }
            }
        }

        private void Button_WOCGuardar_Click(object sender, EventArgs e)
        {
            Clases.Consultar c = new Clases.Consultar();
            c.IdPaciente = int.Parse(txtPlaceHolder2.Text.Trim());
            c.NombrePaciente = txtPlaceHoldernombre.Text.ToUpper().Trim();
            c.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
            c.Edad = int.Parse(txtPlaceHolderedad.Text.Trim());
            c.ActividadFisica = txtPlaceHolderActividadfísica.Text.ToUpper().Trim();
            c.Diagnostico = txtPlaceHolderDiagnostico.Text.ToUpper().Trim();
            c.Estatura = txtPlaceHolderEstatura.Text.Trim();
            c.Peso = txtPlaceHolderPeso.Text.Trim();
            c.Brazo = txtPlaceHolderBrazo.Text.Trim();
            c.Cintura = txtPlaceHolderCintura.Text.Trim();
            c.Cadera = txtPlaceHolderCadera.Text.Trim();
            c.Busto = txtPlaceHolderBusto.Text.Trim();
            c.Estomago = txtPlaceHolderEstomago.Text.Trim();
            c.Complexion = txtPlaceHolderComplexion.Text.Trim();
            c.Dieta = int.Parse(cbDieta.Text);
            c.Tratamiento = txtPlaceHolderTratamiento.Text.ToUpper().Trim();
            c.IMC = txtPlaceHolderIMC.Text.ToUpper().Trim();
            if (c.Guardar() == "ok")
            {
                MessageBox.Show("Se ha guardado la consulta satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(c.Guardar(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TxtPlaceHolderEstatura_TextChanged(object sender, EventArgs e)
        {
            CalcularIMC();
        }

        private void TxtPlaceHolderPeso_Validated(object sender, EventArgs e)
        {
            CalcularIMC();
        }
    }
}
