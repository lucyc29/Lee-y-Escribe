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
    public partial class FVocalO : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalO()
        {
            InitializeComponent();
            Velocidad.Visible = false;
            POlla.Visible = false;
            POjo.Visible = false;
            POso.Visible = false;
            BRepO.Enabled = false;
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
                tarea.Start("Aquí está la cuarta vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, o, si tedas cuenta,"
                        + System.Environment.NewLine
                        + " tiene una forma redonda, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, o, "
                        + System.Environment.NewLine
                        + "al hablar pronunciamos muchas palabras que empiezan con la letra, o, como por ejemplo"
                        + System.Environment.NewLine
                        + "Ojo"
                        + System.Environment.NewLine
                        + "Olla"
                        + System.Environment.NewLine
                        + "Oso");
            }

            if (Time1 == 29)
            {
                POjo.Visible = true;
            }

            if (Time1 == 31)
            {
                POlla.Visible = true;
            }

            if (Time1 == 33)
            {
                POso.Visible = true;
                BRepO.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BRepO_Click(object sender, EventArgs e)
        {
            POso.Visible = false;
            POjo.Visible = false;
            POlla.Visible = false;
            Time1 = 1;
            Tiempo1.Start();
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Aquí está la cuarta vocal, "
                    + System.Environment.NewLine
                    + "esta se llama, o, si tedas cuenta,"
                    + System.Environment.NewLine
                    + " tiene una forma redonda, "
                    + System.Environment.NewLine
                    + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, o, "
                    + System.Environment.NewLine
                    + "al hablar pronunciamos muchas palabras que empiezan con la letra, o, como por ejemplo"
                    + System.Environment.NewLine
                    + "Ojo"
                    + System.Environment.NewLine
                    + "Olla"
                    + System.Environment.NewLine
                    + "Oso");
        }
        private void BTRAS_Click(object sender, EventArgs e)
        {
            Principal casa = new Principal();
            this.Hide();
            casa.Visible = true;
        }
    }
}
