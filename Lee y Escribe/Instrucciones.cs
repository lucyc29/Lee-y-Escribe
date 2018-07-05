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
    public partial class Instrucciones : Form
    {

        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time = 0;
        public Instrucciones()
        {
            InitializeComponent();
            TVelocidad.Visible = false;
            PFlechaL.Visible = false;
            PFlechaL1.Visible = false;
            PFlechaR.Visible = false;
            PAtras.Visible = false;
        }

        private void Narrador(object texto)
        {
            voz.Rate = TVelocidad.Value;
            voz.SelectVoiceByHints(VoiceGender.Female);
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Time += 1;
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            if (Time == 1)
            {
                tarea.Start("Muy bien, Ahora te mostraré lo que debes hacer para las lecciones"
                    + System.Environment.NewLine
                    + "dentro de cada pantalla veras símbolos como estos"
                    + System.Environment.NewLine
                    + "Este sirve para repetir la instrucción, en caso de no haber entendido lo que dije debes precionarlo"
                    + System.Environment.NewLine
                    + "Estos para seleccionar la leccion, o el juego dentro de este panel"
                    + System.Environment.NewLine
                    + "y este sirve para regresar a esta pantalla"
                    );
            }
                if (Time >= 12 && Time %2 == 0)
                {
                    PFlechaR.Visible = true;
                }
                else
                {
                    PFlechaR.Visible = false;
                }
            
            if (Time >= 18 && Time %2 == 0)
            {
                PFlechaR.Visible = false;
                PFlechaL.Visible = true;
                PFlechaL1.Visible = true;
            }
            else
            {
                PFlechaL.Visible = false;
                PFlechaL1.Visible = false;

            }
            if(Time == 24)
            {
                PFlechaL.Visible = false;
                PFlechaL1.Visible = false;
            }

            if (Time >= 24 && Time % 2 == 0)
            {
                PFlechaR.Visible = false;
                PFlechaL.Visible = true;
                PFlechaL1.Visible = true;
            }
            else
            {
                PFlechaL.Visible = false;
                PFlechaL1.Visible = false;
                PAtras.Visible = true;

            }
        }
    }
}
