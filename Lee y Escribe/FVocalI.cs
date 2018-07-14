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
    public partial class FVocalI : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalI()
        {
            InitializeComponent();
            PIsla.Visible = false;
            PIman.Visible = false;
            PIglesia.Visible = false;
            BRepI.Enabled = false;
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
                tarea.Start("Aquí está la tercera vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, i, si tedas cuenta,"
                        + System.Environment.NewLine
                        + " tiene una forma redonda y una pequeña raya a un lado, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, i, "
                        + System.Environment.NewLine
                        + "al hablar pronunciamos muchas palabras que empiezan con la letra, i, como por ejemplo"
                        + System.Environment.NewLine
                        + "Iglesia"
                        + System.Environment.NewLine
                        + "Isla"
                        + System.Environment.NewLine
                        + "Iman");
            }

            if (Time1 == 29)
            {
                PIglesia.Visible = true;
            }

            if (Time1 == 31)
            {
                PIsla.Visible = true;
            }

            if (Time1 == 33)
            {
                PIman.Visible = true;
                BRepI.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BRepI_Click(object sender, EventArgs e)
        {
            PIman.Visible = false;
            PIglesia.Visible = false;
            PIsla.Visible = false;
            Time1 = 1;
            Tiempo1.Start();
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Aquí está la tercera vocal, "
                    + System.Environment.NewLine
                    + "esta se llama, i, si tedas cuenta,"
                    + System.Environment.NewLine
                    + " tiene una forma redonda y una pequeña raya a un lado, "
                    + System.Environment.NewLine
                    + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, i, "
                    + System.Environment.NewLine
                    + "al hablar pronunciamos muchas palabras que empiezan con la letra, i, como por ejemplo"
                    + System.Environment.NewLine
                    + "Iglesia"
                    + System.Environment.NewLine
                    + "Isla"
                    + System.Environment.NewLine
                    + "Iman");
        }
        private void BatrasI_Click(object sender, EventArgs e)
        {
            Principal vocales = new Principal();
            this.Hide();
            vocales.Visible = true;
        }
    }
}
