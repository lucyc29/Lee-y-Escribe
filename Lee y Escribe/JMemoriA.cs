using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lee_y_Escribe
{
    public partial class JMemoriA : Form
    {
        int Columnas_Filas = 4;
        int Movimientos = 0;
        int CantidadCartasVol = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartaSeleccionada;


        PictureBox Temp1;
        PictureBox Temp2;
        int CartaActual;

        public JMemoriA()
        {
            InitializeComponent();
            iniciarJuego();
        }

        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            lblRecord.Text = "0";
            CantidadCartasVol = 0;
            Movimientos = 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartaSeleccionada = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }

            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = Columnas_Filas;
            tablaPanel.ColumnCount = Columnas_Filas;

            for (int i = 0; i < Columnas_Filas; i++)
            {
                var Porcentaje = 150f / (float)Columnas_Filas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));

            }
            int ContadorFichas = 1;

            for (int i = 0; i < Columnas_Filas; i++)
            {
                for (int j = 0; j < Columnas_Filas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", ContadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Libros;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    ContadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);

        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            try
            {
                if (CartaSeleccionada.Count < 2)
                {

                    Movimientos++;
                    lblRecord.Text = Convert.ToString(Movimientos);
                    var CartasSeleccionadaUsuario = (PictureBox)sender;


                    CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadaUsuario.Name) - 1]);
                    CartasSeleccionadaUsuario.Image = RecuperarImagen(CartaActual);
                    CartaSeleccionada.Add(CartasSeleccionadaUsuario);

                    if (CartaSeleccionada.Count == 2)
                    {
                        Temp1 = (PictureBox)CartaSeleccionada[0];
                        Temp2 = (PictureBox)CartaSeleccionada[1];

                        int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(Temp1.Name) - 1]);
                        int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(Temp2.Name) - 1]);
                        
                        if (Carta1 != Carta2)
                        {
                            
                            timer1.Enabled = true;
                            timer1.Start();
                        }
                        else
                        {
                            CantidadCartasVol++;
                            if (CantidadCartasVol > 7)
                            {
                                MessageBox.Show("                         Muy Bien!!!                        ");
                            }
                            Temp1.Enabled = false;
                            Temp2.Enabled = false;
                            CartaSeleccionada.Clear();
                        }
                    }

                }
            }
            catch (Exception )
            {

                throw;
            }
           
        }

        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.Agua;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("Im" + NumeroImagen);
                    break;
            }

            return TmpImg;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
             if (TiempoVirarCarta == 1)
            {
                
                Temp1.Image = Properties.Resources.Libros;
                Temp2.Image = Properties.Resources.Libros;
                CartaSeleccionada.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }


        private void label2_Click_1(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Hide();
            principal.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }
    }
}

