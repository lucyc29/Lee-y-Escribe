using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace Lee_y_Escribe
{
    public partial class Portada : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public Portada()
        {
            InitializeComponent();
            TVelocidad.Visible = false;
            PFlechaR.Visible = false;

        }

        private void Narrador(object texto)
        {
            
                voz.Rate = TVelocidad.Value;
                voz.SelectVoiceByHints(VoiceGender.Female);
                voz.SetOutputToDefaultAudioDevice();
                voz.Speak(texto.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voz.Pause() ;
            Application.Exit();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instrucciones instrucciones = new Instrucciones();
            voz.Pause();
            this.Hide();
            instrucciones.Visible = true;
        }
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            Time1 += 1;
            if (Time1 == 1)
            {
                try
                {
                    tarea.Start("Hola,"
                    + System.Environment.NewLine
                    + "Bienvenido a nuestro espacio aprende a leer y a escribir con tatty,"
                    + System.Environment.NewLine
                    + "Desde ahora, tienes un nuevo amigo quien te mosstrará la manera de leer,"
                    + System.Environment.NewLine
                    + "Para ayudarte debes seguir mi voz y hacer lo que te indique,"
                    + System.Environment.NewLine
                    + "Durante el proceso te mostraré lo que debes hacer para completar la lección,"
                    + System.Environment.NewLine
                    + "Entonces iniciemos, vamos a las lecciones "
                    + System.Environment.NewLine
                    + "Para ir a la pantalla de lecciones presiona aquí,");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
            if (Time1 >= 30 && Time1 % 2 == 0)
            {
                PFlechaR.Visible = true;
            }
            else
            {
                PFlechaR.Visible = false;
            }
            if (Time1 >= 35)
            {
                PFlechaR.Visible = false;
            }
        }
    }
}
