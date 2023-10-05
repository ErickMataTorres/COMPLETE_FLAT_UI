using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace COMPLETE_FLAT_UI
{
    public partial class Frmtransparente : Form
    {

        string user = "";
        string pass = "";
        public Frmtransparente()
        {
            InitializeComponent();

            //esquina redonda
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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


        private void Frmtransparente_Load(object sender, EventArgs e)
        {
            //=======================================================
            //codigo para redondiar el formulario
            //System.Drawing.Drawing2D.GraphicsPath objDraw = new

            //System.Drawing.Drawing2D.GraphicsPath();

            //objDraw.AddEllipse(0, 0, this.Width, this.Height);


            //this.Region = new Region(objDraw);

           
            //=======================================================

            //=======================================================
            //txtboxusuario.GotFocus += new EventHandler(this.TextGotFocus);
            //txtboxusuario.LostFocus += new EventHandler(this.TextLostFocus);
            //=======================================================

            //placeholder en caja de texto
            //=======================================================

            txtboxusuario.Text = "introduzca el usuario";
            txtboxusuario.ForeColor = Color.Gray;
            txtboxusuario.PasswordChar = '\0';
            txtboxcontraseña.Text = "introduzca la contraseña";
            txtboxusuario.ForeColor = Color.Gray;
            //=======================================================


            //mover el formulario 
            //=======================================================
            //mover el formulario
            //======================================================================================================
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmtransparente_MouseMove);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frmtransparente_MouseMove);
            //======================================================================================================
            //=======================================================


            //transparante
            //=======================================================

            this.TransparencyKey = Color.FromArgb(0xaa, 0x00, 0xff);
            this.BackColor = Color.FromArgb(0xaa, 0x00, 0xff);
            //=======================================================
        }



        public void TextGotFocus(object sender, EventArgs e)
        {
            //if (txtboxusuario.PlaceholderText == "Search Facebook")
            //{
            //    txtboxusuario.Text = "";
            //    txtboxusuario.ForeColor = Color.Black;
            //}
        }

        private void Txtboxusuario_Enter(object sender, EventArgs e)
        {
            txtboxusuario.Text = "";
            txtboxusuario.ForeColor = Color.Black;
        }

        private void Txtboxusuario_Leave(object sender, EventArgs e)
        {
            user = txtboxusuario.Text;
            if (user.Equals("introduzca el usuario"))
            {
                txtboxusuario.Text = "introduzca el usuario";
                txtboxusuario.ForeColor = Color.Gray;

            }
            else
            {
                if (user.Equals(""))
                {

                    txtboxusuario.Text = "introduzca el usuario";
                    txtboxusuario.ForeColor = Color.Gray;
                }
                else
                {
                    txtboxusuario.Text = user;
                    txtboxusuario.ForeColor = Color.Black;
                }
            }
        }

        private void Txtboxcontraseña_Enter(object sender, EventArgs e)
        {
            txtboxcontraseña.Text = "";
            txtboxcontraseña.ForeColor = Color.Black;
            txtboxcontraseña.PasswordChar = '*';
        }

        private void Txtboxcontraseña_Leave(object sender, EventArgs e)
        {
            pass = txtboxcontraseña.Text;
            if (pass.Equals("introduzca la contraseña"))
            {
                txtboxcontraseña.Text = "introduzca la contraseña";
                txtboxcontraseña.ForeColor = Color.Gray;

            }
            else
            {
                if (pass.Equals(""))
                {
                    txtboxcontraseña.PasswordChar = '\0';
                    txtboxcontraseña.Text = "introduzca la contraseña";
                    txtboxcontraseña.ForeColor = Color.Gray;
                }
                else
                {
                    txtboxcontraseña.PasswordChar = '*';
                    txtboxcontraseña.Text = pass;
                    txtboxcontraseña.ForeColor = Color.Black;
                }
            }
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

        private void Frmtransparente_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }
    }


}




