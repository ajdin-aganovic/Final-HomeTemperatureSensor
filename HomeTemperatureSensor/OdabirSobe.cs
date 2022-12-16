using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTemperatureSensor
{
    public partial class OdabirSobe : Form
    {
        public static OdabirSobe instancaOdabira;
        public Button potvrdniGumb;
        public Button negirajuciGumb;
        public TextBox vrijednost;
        public int Izabrana;
        public int VrijednostZaSobu
        {
            
            get
            {
                return Izabrana=int.Parse(textBox1.Text);
            }
        }
        public OdabirSobe()
        {
            InitializeComponent();
            instancaOdabira = this;
            potvrdniGumb = button1;
            negirajuciGumb = button2;
            vrijednost = textBox1;

        }

        private void OdabirSobe_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
