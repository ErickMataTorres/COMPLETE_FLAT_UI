using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace COMPLETE_FLAT_UI.Ventanas
{
    public partial class VentanaBuscar : Form
    {
        string miTabla;
        string misCampos;
        string miOrden;
        string miregreso;
        string res = "";
        public VentanaBuscar()
        {
            InitializeComponent();

             //esquina redonda
            //========================================================================================
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //========================================================================================
        }



        //transpararente datagri
        //=================================

        //dgvDatos.DataBindings.Add(nameof(DataGrid.BackgroundColor),
        //                    this,
        //                    nameof(Control.BackColor));
        //=================================

        //esquina redonda del pinturebox
        //==================================================================

        //==================================================================
        //esquina redonda del pinturebox

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


        public string Busca(string tabla, string campos, string ordenar, string regresar, string titulo)
        {
            miTabla = tabla;
            misCampos = campos;
            miOrden = ordenar;
            miregreso = regresar;
            this.Text = "Consulta de " + titulo;
            this.ShowDialog();
            return res;
        }
        private void VentanaBuscar_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = Clases.Buscar.Consulta(miTabla, misCampos, miOrden, txtPlaceHolderBuscar.Text.ToUpper().Trim());
            dgvDatos.Columns[miOrden].Width = dgvDatos.Width - dgvDatos.Columns[0].Width - dgvDatos.RowHeadersWidth - 2;

          


            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaBuscar_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaBuscar_MouseMove);
            //======================================================================================================
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    dgvDatos.DataSource = Clases.Buscar.Consulta(miTabla, misCampos, miOrden, txtBuscar.Text.ToUpper().Trim());
            //    dgvDatos.Columns[miOrden].Width = dgvDatos.Width - dgvDatos.Columns[0].Width - dgvDatos.RowHeadersWidth - 2;
            //}
        }

        private void DgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dgvDatos.Rows.Count; count++)
            {
                if ((count % 2) == 0)
                {
                    dgvDatos.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 153, 0);
                }
                else
                {
                    dgvDatos.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 153, 0);




                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //res = dgvDatos.CurrentRow.Cells[miregreso].Value.ToString();
            //Close();
        }

        private void DgvDatos_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void DgvDatos_DoubleClick(object sender, EventArgs e)
        {
            res = dgvDatos.CurrentRow.Cells[miregreso].Value.ToString();
            Close();
        }

        private void TxtPlaceHolderBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvDatos.DataSource = Clases.Buscar.Consulta(miTabla, misCampos, miOrden, txtPlaceHolderBuscar.Text.ToUpper().Trim());
                dgvDatos.Columns[miOrden].Width = dgvDatos.Width - dgvDatos.Columns[0].Width - dgvDatos.RowHeadersWidth - 2;
            }

        }

        private void TxtPlaceHolderBuscar_KeyUp(object sender, KeyEventArgs e)
        {

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

        private void VentanaBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void Button_WOC2Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_WOCAceptar_Click(object sender, EventArgs e)
        {
            res = dgvDatos.CurrentRow.Cells[miregreso].Value.ToString();
            Close();
        }

        private void DgvDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        //redendodear el pinturebox
        //==================================================================================
       

        //===================================================================================================
        // fin función para mover el formulario
    }
}
