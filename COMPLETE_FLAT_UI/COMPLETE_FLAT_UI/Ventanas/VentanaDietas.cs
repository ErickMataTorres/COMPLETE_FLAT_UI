using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI.Ventanas
{
    public partial class VentanaDietas : Form
    {
        public VentanaDietas()
        {
            InitializeComponent();

            //esquina redonda
            //========================================================================================
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //========================================================================================
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

        private void VentanaDietas_Load(object sender, EventArgs e)
        {
            Activar(true);
            //dgvDieta.AllowUserToAddRows = false;


            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaDietas_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaDietas_MouseMove);
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

        private void VentanaDietas_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void Activar(bool activo)
        {
            //panel1.Enabled = activo;
            //panel2.Enabled = !activo;
            //panel3.Enabled = !activo;
            button_WOCEliminar.Enabled = false;
            if (activo)
            {
                dgvDieta.DataSource = null;
            }
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

            //    dgvDieta.DataSource = Clases.Dietas.TablaDietas(int.Parse(txtId.Text.Trim()));
            //    dgvDieta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //    dgvDieta.Columns[0].Width = 50;
            //    dgvDieta.Columns[1].Width = 250;
            //    dgvDieta.Columns[2].Width = 250;
            //    dgvDieta.Columns[3].Width = 250;
            //    button_WOCEliminar.Enabled = true;
            //    dgvDieta.DefaultCellStyle.BackColor = Color.FromArgb(236, 198, 215); 
            //    dgvDieta.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Cancelar la dieta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
            //    Activar(true);
            //}
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //SqlConnection conx = Conexion.ClaseConexion.Conectar();
            //SqlCommand command = new SqlCommand("spGuardarDieta",conx);
            //command.CommandType = CommandType.StoredProcedure;
            //int contador = 1;
            //conx.Open();
            //try
            //{
            //    foreach(DataGridViewRow row in dgvDieta.Rows)
            //    {
            //        command.Parameters.Clear();
            //        command.Parameters.AddWithValue("@IdDieta", txtId.Text.Trim());
            //        command.Parameters.AddWithValue("@Dia", row.Cells["Dia"].Value);
            //        command.Parameters.AddWithValue("@Desayuno", row.Cells["Desayuno"].Value);
            //        command.Parameters.AddWithValue("@Comida", row.Cells["Comida"].Value);
            //        command.Parameters.AddWithValue("@Cena", row.Cells["Cena"].Value);
            //        if (contador!=dgvDieta.Rows.Count)
            //        {
            //            command.ExecuteNonQuery();
            //        }
            //        contador++;
            //    }                
            //    MessageBox.Show("Se ha guardado correctamente");
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message);
            //}
        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_WOCGuardar_Click(object sender, EventArgs e)
        {

            SqlConnection conx = Conexion.ClaseConexion.Conectar();
            SqlCommand command = new SqlCommand("spGuardarDieta", conx);
            command.CommandType = CommandType.StoredProcedure;
            int contador = 1;
            conx.Open();
            try
            {
                foreach (DataGridViewRow row in dgvDieta.Rows)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@IdDieta", txtPlaceHolderId.Text.Trim());
                    command.Parameters.AddWithValue("@Dia", row.Cells["Dia"].Value);
                    command.Parameters.AddWithValue("@Desayuno", row.Cells["Desayuno"].Value);
                    command.Parameters.AddWithValue("@Comida", row.Cells["Comida"].Value);
                    command.Parameters.AddWithValue("@Cena", row.Cells["Cena"].Value);
                    if (contador != dgvDieta.Rows.Count)
                    {
                        command.ExecuteNonQuery();
                    }
                    contador++;
                }
                MessageBox.Show("Se ha guardado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Button_WOCCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar la dieta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Activar(true);
            }
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

                dgvDieta.DataSource = Clases.Dietas.TablaDietas(int.Parse(txtPlaceHolderId.Text.Trim()));
                dgvDieta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvDieta.Columns[0].Width = 50;
                dgvDieta.Columns[1].Width = 250;
                dgvDieta.Columns[2].Width = 250;
                dgvDieta.Columns[3].Width = 250;
                button_WOCEliminar.Enabled = true;
                dgvDieta.DefaultCellStyle.BackColor = Color.FromArgb(236, 198, 215);
                dgvDieta.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
        }

        private void Btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.circleoscuro;
        }

        private void Btncerrar_MouseLeave(object sender, EventArgs e)
        {
              btncerrar.Image = Properties.Resources.circlerojo;
        }
    }
}
