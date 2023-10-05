using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace FuncionesGeneralesCs.ControlesPersonalizados
{
    public class TxtPlaceHolder : TextBox
    {
        protected string texto = "PlaceHolderText";
        protected string tituloTTip = "¡Atención!";
        protected string descripcionTTip = "Campo requerido.";
        protected Color colorTextoDefault = Color.Gray;
        protected Color colorTextoObligatorio = Color.Red;
        protected ToolTipIcon iconoTTip = ToolTipIcon.Info;
        private Panel contenedor;
        private Font fuente;
        private SolidBrush establecerColorTexto;
        private bool obligatorio = false;
        private bool noPerderFoco = false;
        private int vecesFocoObtenido = 0;
        public Color colorTexto = Color.Gray;

        public TxtPlaceHolder()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            fuente = Font;
            CharacterCasing = CharacterCasing.Upper;
            contenedor = null;

            MuestraPlaceHolder();

            Enter += new EventHandler(ObtieneFoco);
            Leave += new EventHandler(PierdeFoco);
            TextChanged += new EventHandler(CambiaTexto);
        }

        private void EliminaPlaceHolder()
        {
            if (contenedor != null)
            {
                Controls.Remove(contenedor);
                contenedor = null;
            }
        }

        private void MuestraPlaceHolder()
        {
            if (contenedor == null && TextLength <= 0)
            {
                contenedor = new Panel();
                contenedor.Paint += new PaintEventHandler(contenedorPaint);
                contenedor.Invalidate();
                contenedor.Click += new EventHandler(contenedorClick);
                Controls.Add(contenedor);
            }
        }

        private void contenedorClick(object sender, EventArgs e)
        {
            Focus();
        }

        private void contenedorPaint(object sender, PaintEventArgs e)
        {
            contenedor.Location = new Point(2, 0);
            contenedor.Height = Height;
            contenedor.Width = Width;
            contenedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            establecerColorTexto = new SolidBrush(colorTexto);
            Graphics g = e.Graphics;
            g.DrawString(texto, fuente, establecerColorTexto, new PointF(-1f, 1f));
        }

        private void ObtieneFoco(object sender, EventArgs e)
        {
            vecesFocoObtenido += 1;
        }

        private void PierdeFoco(object sender, EventArgs e)
        {
            if (TextLength > 0)
            {
                EliminaPlaceHolder();
            }
            else
            {
                if (obligatorio)
                {
                    colorTexto = colorTextoObligatorio;
                    ToolTip ttip = new ToolTip();
                    ttip.ToolTipIcon = ToolTipIcon.Info;
                    ttip.ToolTipTitle = tituloTTip;
                    ttip.UseFading = true;
                    ttip.Show(descripcionTTip, this, 1000);

                    if (noPerderFoco && obligatorio)
                    {
                        Focus();
                    }
                }
                else
                {
                    colorTexto = colorTextoDefault;
                }

                Invalidate();
            }
        }

        private void CambiaTexto(object sender, EventArgs e)
        {
            if (TextLength > 0)
            {
                EliminaPlaceHolder();
            }
            else
            {
                MuestraPlaceHolder();

                if (vecesFocoObtenido >= 1 && obligatorio)
                {
                    colorTexto = colorTextoObligatorio;
                    ToolTip ttip = new ToolTip();
                    ttip.ToolTipIcon = ToolTipIcon.Info;
                    ttip.ToolTipTitle = tituloTTip;
                    ttip.UseFading = true;
                    ttip.Show(descripcionTTip, this, 1000);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            MuestraPlaceHolder();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            if (contenedor != null)
            {
                contenedor.Invalidate();
            }
        }

        [Category("Atributos PlaceHolder")]
        [Description("Establece el texto a mostrar en el PlaceHolder.")]
        public string PlaceHolderText
        {
            get
            {
                return texto;
            }
            set
            {
                texto = value;
                Invalidate();
            }
        }

        [Category("Atributos PlaceHolder")]
        [Description("Establece el estilo de fuente del PlaceHolder.")]
        public Font PlaceHolderFont
        {
            get
            {
                return fuente;
            }
            set
            {
                fuente = value;
                Invalidate();
            }
        }

        [Category("Atributos PlaceHolder")]
        [Description("Indica al usuario si el campo es obligatorio.")]
        public bool PlaceHolderFieldRequired
        {
            get
            {
                return obligatorio;
            }
            set
            {
                obligatorio = value;

                if (noPerderFoco)
                {
                    noPerderFoco = value;
                }

                Invalidate();
            }
        }

        [Category("Atributos PlaceHolder")]
        [Description("Establece el título del tooltip cuando un campo es obligatorio.")]
        public string PlaceHolderTitleToolTip
        {
            get
            {
                return tituloTTip;
            }
            set
            {
                tituloTTip = value;
                Invalidate();
            }
        }

        [Category("Atributos PlaceHolder")]
        [Description("Establece la descripción del tooltip cuando un campo el obligatorio.")]
        public string PlaceHolderDescriptionToolTip
        {
            get
            {
                return descripcionTTip;
            }
            set
            {
                descripcionTTip = value;
                Invalidate();
            }
        }

        [Category("Atributos PlaceHolder")]
        [Description("Establece si el foco no saldrá del campo hasta que sea llenado.")]
        public bool PlaceHolderFieldRequiredFocused
        {
            get
            {
                return noPerderFoco;
            }
            set
            {
                noPerderFoco = value;

                if (!obligatorio)
                {
                    obligatorio = value;
                }

                Invalidate();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
