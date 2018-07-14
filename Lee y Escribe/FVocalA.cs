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
    public partial class FVocalA : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time1 = 0;
        public FVocalA()
        {
            InitializeComponent();
            Velocidad.Visible = false;
            PAnillo.Visible = false;
            PAbeja.Visible = false;
            PAvion.Visible = false;
            BRepA.Enabled = false;
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
                tarea.Start("Excelente, "
                        + System.Environment.NewLine
                        + "Aquí está la primera vocal, "
                        + System.Environment.NewLine
                        + "esta se llama, a, si tedas cuenta,"
                        + System.Environment.NewLine
                        + " tiene una forma redonda y una pequeña raya a un lado, "
                        + System.Environment.NewLine
                        + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, a, "
                        + System.Environment.NewLine
                        + "al hablar pronunciamos muchas palabras que empiezan con la letra, a, como por ejemplo"
                        + System.Environment.NewLine
                        + "Abeja"
                        + System.Environment.NewLine
                        + "Avión"
                        + System.Environment.NewLine
                        + "Anillo");
            }

            if (Time1 == 29)
            {
                PAbeja.Visible = true;
            }

            if (Time1 == 31)
            {
                PAvion.Visible = true;
            }

            if (Time1 == 33)
            {
                PAnillo.Visible = true;
                BRepA.Enabled = true;
                Tiempo1.Stop();
            }
        }

        private void BRepA_Click(object sender, EventArgs e)
        {
            PAnillo.Visible = false;
            PAbeja.Visible = false;
            PAvion.Visible = false;
            Time1 = 1;
            Tiempo1.Start();
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            tarea.Start("Excelente, "
                    + System.Environment.NewLine
                    + "Aquí está la primera vocal, "
                    + System.Environment.NewLine
                    + "esta se llama, a, si tedas cuenta,"
                    + System.Environment.NewLine
                    + " tiene una forma redonda y una pequeña raya a un lado, "
                    + System.Environment.NewLine
                    + "para pronunciar el nombre de esta letra lo hacemos con la boca abierta grande y decimos, a, "
                    + System.Environment.NewLine
                    + "al hablar pronunciamos muchas palabras que empiezan con la letra, a, como por ejemplo"
                    + System.Environment.NewLine
                    + "Abeja"
                    + System.Environment.NewLine
                    + "Avión"
                    + System.Environment.NewLine
                    + "Anillo");
        }
     
        private void FVocalA_Load(object sender, EventArgs e)
        {

        }

        private void BAtrasA_Click_1(object sender, EventArgs e)
        {
            Principal vocales = new Principal();
            voz.Pause();
            this.Hide();
            vocales.Visible = true;
        }
    }
}
