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
                    + "Este sirve para repetir la instrucción"
                    + System.Environment.NewLine
                    + "Este para seleccionar la leccion, o el juego dentro de este panel"
                    + System.Environment.NewLine
                    + "y este para regresar a esta pantalla"
                    );
            }
            if (Time == 10)
            {
                Principal principal = new Principal();
                this.Hide();
                principal.Visible = true;
            }
        }
    }
}
