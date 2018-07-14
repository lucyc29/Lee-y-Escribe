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
    public partial class Principal : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
        int Time = 0;
        public Principal()
        {
            InitializeComponent();
            TVelocidad.Visible = false;
            BRepetir.Enabled = false;
        }

        private void Narrador(object texto)
        {
            voz.Rate = TVelocidad.Value;
            voz.SelectVoiceByHints(VoiceGender.Female);
            //voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Narrador));
            Time += 1;

            if (Time == 1)
            {
                try
                {
                    tarea.Start("Elige que deseas hacer"); 
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la Voz");
                    throw;
                }
            }
        }

        private void BJuegos_Click(object sender, EventArgs e)
        {
            JMemoriA memoria = new JMemoriA();
            voz.Pause();
            this.Hide();
            memoria.Visible = true;
        }

        private void LVocales_Click(object sender, EventArgs e)
        {
            PruebaDePaneles pruebapaneles = new PruebaDePaneles();
            voz.Pause();
            this.Hide();
            pruebapaneles.Visible = true;
        }
    }
}