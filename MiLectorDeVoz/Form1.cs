using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //agregamos libreria
using System.Speech; //hacer q la compu hable, referencia
using System.Speech.Synthesis;

namespace MiLectorDeVoz
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer reader =new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            reader.SpeakAsync(lbTxt.Text); //leemos el contenido
        }

        private void bandeja_Click(object sender, EventArgs e)
        {
            Stream str;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if((str=openFileDialog.OpenFile())!=null)
                {
                    string fname=openFileDialog.FileName;
                    string filetxt = File.ReadAllText(fname);
                    lbTxt.Text = filetxt;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reader != null) 
            {
                if(reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(reader !=null)
            {
                reader.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }
    }
}
