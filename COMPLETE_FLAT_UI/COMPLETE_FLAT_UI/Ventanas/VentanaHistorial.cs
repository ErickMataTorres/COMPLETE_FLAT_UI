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
    public partial class VentanaHistorial : Form
    {
        public VentanaHistorial()
        {
            InitializeComponent();

            //esquina redonda
            //========================================================================================
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //========================================================================================
        }

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
        private void VentanaHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = Clases.Consultar.TablaHistorial("", Convert.ToDateTime(null), Convert.ToDateTime(null), 1);



            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaHistorial_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaHistorial_MouseMove);
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

        // fin función para mover el formulario 
        //===================================================================================================
        private void DiferenciaPeso()
        {
            DataTable t = Clases.Consultar.TablaHistorial(txtPlaceHolderId.Text.ToUpper().Trim(),Convert.ToDateTime(null),Convert.ToDateTime(null),1);
            txtPlaceHolderPeso.Text = string.Empty;
            if (t.Rows.Count > 1)
            {
                decimal ultimoPeso = decimal.Parse(t.Rows[0]["Peso"].ToString());
                decimal penultimoPeso = decimal.Parse(t.Rows[1]["Peso"].ToString());
                decimal ultimoBrazo = decimal.Parse(t.Rows[0]["Brazo"].ToString());
                decimal penultimoBrazo = decimal.Parse(t.Rows[1]["Brazo"].ToString());
                decimal ultimaCintura = decimal.Parse(t.Rows[0]["Cintura"].ToString());
                decimal penultimaCintura = decimal.Parse(t.Rows[1]["Cintura"].ToString());
                decimal ultimaCadera = decimal.Parse(t.Rows[0]["Cadera"].ToString());
                decimal penultimaCadera = decimal.Parse(t.Rows[1]["Cadera"].ToString());
                decimal ultimoBusto = decimal.Parse(t.Rows[0]["Busto"].ToString());
                decimal penultimoBusto = decimal.Parse(t.Rows[1]["Busto"].ToString());
                decimal ultimoEstomago = decimal.Parse(t.Rows[0]["Estomago"].ToString());
                decimal penultimoEstomago = decimal.Parse(t.Rows[1]["Estomago"].ToString());

                decimal diferenciaPeso = (ultimoPeso - penultimoPeso);
                decimal diferenciaBrazo = (ultimoBrazo - penultimoBrazo);
                decimal diferenciaCintura = (ultimaCintura - penultimaCintura);
                decimal diferenciaCadera = (ultimaCadera- penultimaCadera);
                decimal diferenciaBusto = (ultimoBusto - penultimoBusto);
                decimal diferenciaEstomago = (ultimoEstomago - penultimoEstomago);
                
                if (diferenciaPeso < 0)
                {
                    diferenciaPeso = (diferenciaPeso * (-1));
                    txtPlaceHolderPeso.Text = diferenciaPeso.ToString() + " KG perdido(s)";
                }
                else
                {
                    txtPlaceHolderPeso.Text = diferenciaPeso.ToString() + " KG subido(s)";
                }
                if (diferenciaBrazo < 0)
                {
                    diferenciaBrazo = (diferenciaBrazo * (-1));
                    txtPlaceHolderBrazo.Text = diferenciaBrazo.ToString() + " CM perdido(s)";
                }
                else
                {
                    txtPlaceHolderBrazo.Text = diferenciaPeso.ToString() + " CM subido(s)";
                }
                if (diferenciaCintura < 0)
                {
                    diferenciaCintura = (diferenciaCintura * (-1));
                    txtPlaceHolderCintura.Text = diferenciaCintura.ToString() + " CM perdido(s)";
                }
                else
                {
                    txtPlaceHolderCintura.Text = diferenciaCintura.ToString() + " CM subido(s)";
                }
                if (diferenciaCadera < 0)
                {
                    diferenciaCadera= (diferenciaCadera* (-1));
                    txtPlaceHolderCadera.Text = diferenciaCadera.ToString() + " CM perdido(s)";
                }
                else
                {
                    txtPlaceHolderCadera.Text = diferenciaCadera.ToString() + " CM subido(s)";
                }
                if (diferenciaBusto < 0)
                {
                    diferenciaBusto = (diferenciaBusto* (-1));
                    txtPlaceHolderBusto.Text = diferenciaBusto.ToString() + " CM perdido(s)";
                }
                else
                {
                    txtPlaceHolderBusto.Text = diferenciaBusto.ToString() + " CM subido(s)";
                }
                if (diferenciaEstomago< 0)
                {
                    diferenciaEstomago= (diferenciaEstomago* (-1));
                    txtPlaceHolderEstomago.Text = diferenciaEstomago.ToString() + " CM perdido(s)";
                }
                else
                {
                    txtPlaceHolderEstomago.Text = diferenciaEstomago.ToString() + " CM subido(s)";
                }
            }
        }
        private void TxtId_KeyUp(object sender, KeyEventArgs e)
        {
        }
        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    if (txtId.Text == string.Empty)
            //    {
            //        return;
            //    }
            //    DiferenciaPeso();
            //    if (Char.IsControl(e.KeyChar))
            //    {
            //        dgvHistorial.DataSource = Clases.Consultar.TablaHistorialTexto(txtId.Text.ToUpper().Trim(), Convert.ToDateTime(null), Convert.ToDateTime(null), 1);
            //    }
            //    else
            //    {
            //        if (Char.IsDigit(e.KeyChar) || Char.IsNumber(e.KeyChar))
            //        {
            //            dgvHistorial.DataSource = Clases.Consultar.TablaHistorial(txtId.Text.ToUpper().Trim(), Convert.ToDateTime(null), Convert.ToDateTime(null), 1);
            //        }
            //    }
            //}
        }
        private void DtpHasta_ValueChanged(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = Clases.Consultar.TablaHistorial(txtPlaceHolderId.Text.ToUpper().Trim(), dtpDesde.Value, dtpHasta.Value, 2);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Ventanas.VentanaBuscar ventana = new Ventanas.VentanaBuscar();
            string resultado = ventana.Busca("TablaConsultar", "IdPaciente, Nombre_Paciente", "Nombre_Paciente", "Nombre_Paciente", "Historial");
            if (resultado != "")
            {
                txtPlaceHolderId.Text = resultado;
                KeyPressEventArgs tecla = new KeyPressEventArgs((char)Keys.Enter);
                TxtPlaceHolderId_KeyPress(sender, tecla);
            }
        }

        private void VentanaHistorial_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void TxtPlaceHolderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPlaceHolderId.Text == string.Empty)
                {
                    return;
                }
                DiferenciaPeso();
                if (Char.IsControl(e.KeyChar))
                {
                    dgvHistorial.DataSource = Clases.Consultar.TablaHistorialTexto(txtPlaceHolderId.Text.ToUpper().Trim(), Convert.ToDateTime(null), Convert.ToDateTime(null), 1);
                }
                else
                {
                    if (Char.IsDigit(e.KeyChar) || Char.IsNumber(e.KeyChar))
                    {
                        dgvHistorial.DataSource = Clases.Consultar.TablaHistorial(txtPlaceHolderId.Text.ToUpper().Trim(), Convert.ToDateTime(null), Convert.ToDateTime(null), 1);
                    }
                }
            }
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btncerrar_MouseEnter(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.closesrojo;
        }

        private void Btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.Image = Properties.Resources.closeazul;
        }

        private void DgvHistorial_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int count = 0; count < dgvHistorial.Rows.Count; count++)
            {
                if ((count % 2) == 0)
                {
                    dgvHistorial.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 230, 230);
                }
                else
                {
                    dgvHistorial.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 230, 230);

                }
            }
        }

        private void BtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.Image = Properties.Resources.calcularcolorido;
        }

        private void BtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.Image = Properties.Resources.calcular64; ;
        }
    }
}