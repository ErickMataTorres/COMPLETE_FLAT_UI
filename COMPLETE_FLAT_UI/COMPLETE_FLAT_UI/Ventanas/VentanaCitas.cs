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
    public partial class VentanaCitas : Form
    {
        public VentanaCitas()
        {
            InitializeComponent();

            //esquina redonda
            //========================================================================================
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //========================================================================================
            //esquina redonda
        }

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

        private void DgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaCitas_Load(object sender, EventArgs e)
        {
            dgvCitas.DataSource = Clases.ReservarCita.Citas(txtBuscar.Text.ToUpper().Trim());
            dgvCitas.Columns["IdPaciente"].Width = 100;
            dgvCitas.Columns["Nombre"].Width = 300;
            dgvCitas.Columns["Cita"].Width = 100;
            dgvCitas.Columns["Hora"].Width = 100;

            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaCitas_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaCitas_MouseMove);
            //======================================================================================================
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
        private void VentanaCitas_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }
        // función para mover el formulario 
        //===================================================================================================

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvCitas.DataSource = Clases.ReservarCita.Citas(txtBuscar.Text.ToUpper().Trim());
                dgvCitas.Columns["IdPaciente"].Width = 100;
                dgvCitas.Columns["Nombre"].Width = 300;
                dgvCitas.Columns["Cita"].Width = 100;
                dgvCitas.Columns["Hora"].Width = 100;
            }
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.canceloscuro;
        }

        private void Btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.cancelrojo;
        }
    }
}
