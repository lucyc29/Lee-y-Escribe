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
    public partial class FVocalE : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalE()
        {
            InitializeComponent();
            Velocidad.Visible = false;
            BRepE.Enabled = false;
            PElefante.Visible = false;
            PEspada.Visible = false;
            PEstrella.Visible = false;
        }
        private void Narrador(object texto)
        {

            voz.SelectVoiceByHints(VoiceGender.Female);
            voz.Rate = Velocidad.Value;
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());

        }
        private void Tiempo1_Tick(object sender, EventArgs e)
        {
            Time1 += 1;
            if (Time1 == 1)
            {
                Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
                tarea.Start("Excelente, si estás en este nivel, ya aprendiste la letra, a, y"
                        + System.Environment.NewLine
                        + "Aquí está la segunda vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, e, si tedas cuenta,"
                        + System.Environment.NewLine
                        + "tiene una forma media redonda, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos sin  abrir la boca tanto y decimos, e, con esta tambien "
                        + System.Environment.NewLine
                        + "al hablar pronunciamos muchas palabras que empiezan con la letra, e, como por ejemplo"
                        + System.Environment.NewLine
                        + "Elefante"
                        + System.Environment.NewLine
                        + "Estrella"
                        + System.Environment.NewLine
                        + "Espada");
            }

            if (Time1 == 29)
            {
                PElefante.Visible = true;
            }

            if (Time1 == 31)
            {
                PEstrella.Visible = true;
            }

            if (Time1 == 33)
            {
                PEspada.Visible = true;
                BRepE.Enabled = true;
                Tiempo1.Stop();
            }
        }
        private void BRepE_Click(object sender, EventArgs e)
        {
            PElefante.Visible = false;
            PEspada.Visible = false;
            PEstrella.Visible = false;
            Time1 = 1;
            Tiempo1.Start();
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Aquí está la segunda vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, e, si tedas cuenta,"
                        + System.Environment.NewLine
                        + "tiene una forma media redonda, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos sin  abrir la boca tanto y decimos, e, con esta tambien "
                        + System.Environment.NewLine
                        + "al hablar pronunciamos muchas palabras que empiezan con la letra, e, como por ejemplo"
                        + System.Environment.NewLine
                        + "Elefante"
                        + System.Environment.NewLine
                        + "Estrella"
                        + System.Environment.NewLine
                        + "Espada");

        }
        private void BatrasE_Click(object sender, EventArgs e)
        {
            Principal vocales = new Principal();
            this.Hide();
            vocales.Visible = true;
        }
    }
}
