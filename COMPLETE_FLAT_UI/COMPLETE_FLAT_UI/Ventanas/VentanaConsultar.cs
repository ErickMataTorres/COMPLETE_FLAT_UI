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

namespace COMPLETE_FLAT_UI.Ventanas
{
    public partial class VentanaConsultar : Form
    {
        public VentanaConsultar()
        {
            InitializeComponent();

            
           
            //esquina redonda
         //========================================================================================
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
         //========================================================================================
            //esquina redonda
        }

        //vatiables de posicion
        //============================
        int lx, ly;
        int sw, sh;
        //============================


        //esquinas redonnda
        //==================================================================
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
        //==================================================================
          //fin esquinas redonnda

        private void VentanaConsultar_Load(object sender, EventArgs e)
        {
            CargarData(txtPlaceHolderBuscar.Text.ToUpper().Trim());

            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaConsultar_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaConsultar_MouseMove);
            //======================================================================================================
        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            //Ventanas.VentanitaConsultar ventana = new Ventanas.VentanitaConsultar();
            //ventana.Nuevo();
            //if (ventana.DialogResult == DialogResult.OK)
            //{
            //    CargarData(txtPlaceHolderBuscar.Text.ToUpper().Trim());
            //}
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //Ventanas.VentanitaConsultar ventana = new Ventanas.VentanitaConsultar();
            //if (dgvConsultas.SelectedRows == null)
            //{
            //    return;
            //}
            //ventana.Modificar(int.Parse(dgvConsultas.CurrentRow.Cells["IdPaciente"].Value.ToString()));
            ////ventana.Modificar(int.Parse(dgvConsultas.CurrentRow.Cells["IDPACIENTE"].Value.ToString()));


            ////ventana.Modificar(int.Parse(dgvConsultas.CurrentRow.Cells["IdPaciente, Nombre_Paciente, Fecha_Nacimiento,Edad, Actividad_Fisica, Diagnostico, Estatura, Peso, Brazo, Cintura, Cadera, Busto, Estomago, Complexion, Dieta, Fecha, Tratamiento,IMC "].Value.ToString()));

            //if (ventana.DialogResult == DialogResult.OK)
            //{
            //    CargarData(txtPlaceHolderBuscar.Text.ToUpper().Trim());
            //}
        }
        private void CargarData(string texto)
        {
            dgvConsultas.DataSource = Clases.Consultar.TablaConsultar(texto);
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
        }

        //private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        CargarData(txtBuscar.Text.ToUpper().Trim());
        //    }
        //}

        private void DgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtPlaceHolderBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CargarData(txtPlaceHolderBuscar.Text.ToUpper().Trim());
            }
        }



          // función para mover el formulario 
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

        private void VentanaConsultar_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void Button_WOCNueva_Click(object sender, EventArgs e)
        {
            Ventanas.VentanitaConsultar ventana = new Ventanas.VentanitaConsultar();
            ventana.Nuevo();
            if (ventana.DialogResult == DialogResult.OK)
            {
                CargarData(txtPlaceHolderBuscar.Text.ToUpper().Trim());
            }
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //imagenes para los botones redondo cambia de imagen al pasar el mouse eventos
        //=============================================================================
        private void Btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.oscuroclose;
        }

        private void Btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.closeclaro;
        }

        private void Button_WOCConsultar_Click(object sender, EventArgs e)
        {
            Ventanas.VentanitaConsultar ventana = new Ventanas.VentanitaConsultar();
            if (dgvConsultas.SelectedRows == null)
            {
                return;
            }
            ventana.Modificar(int.Parse(dgvConsultas.CurrentRow.Cells["IdPaciente"].Value.ToString()));
            //ventana.Modificar(int.Parse(dgvConsultas.CurrentRow.Cells["IDPACIENTE"].Value.ToString()));


            //ventana.Modificar(int.Parse(dgvConsultas.CurrentRow.Cells["IdPaciente, Nombre_Paciente, Fecha_Nacimiento,Edad, Actividad_Fisica, Diagnostico, Estatura, Peso, Brazo, Cintura, Cadera, Busto, Estomago, Complexion, Dieta, Fecha, Tratamiento,IMC "].Value.ToString()));

            if (ventana.DialogResult == DialogResult.OK)
            {
                CargarData(txtPlaceHolderBuscar.Text.ToUpper().Trim());
            }
        }

        //=============================================================================
        //fin imagenes para los botones redondo cambia de imagen al pasar el mouse eventos
        private void DgvConsultas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dgvConsultas.Rows.Count; count++)
            {
                if ((count % 2) == 0)
                {
                    dgvConsultas.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.GhostWhite;
                }
                else
                {
                    dgvConsultas.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.GhostWhite;




                }
            }
        }

        private void Button_WOCcancelar_Click(object sender, EventArgs e)
        {
            Close();
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
    }
        //===================================================================================================
        // fin función para mover el formulario
}
