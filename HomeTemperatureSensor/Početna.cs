using HomeTemperatureSensor.Models;
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
    public partial class Početna : Form
    {
        private double x = 0;
        public static Početna instanca;
        private static int brojSobe = 1;
        private string imeSobe = "Nema sobe sa tim brojem";
        private List<sobe> sveSobe = new List<sobe>();

        public Početna()
        {
            InitializeComponent();
            instanca = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static float ToSingle(double value)
        {
            return (float)value;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PodaciOTemperaturama podaciOTemperaturama = new PodaciOTemperaturama();
            podaciOTemperaturama.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmZvuk.Visible = false;
          
        }
        private void Početna_Load(object sender, EventArgs e)
        {

            MyContext myContext = new MyContext();
            sobe soba = new sobe();
            sveSobe = myContext.sobe.ToList();
            Random ran = new Random();
            podaci podatak = new podaci();
            button1.Visible = true;
            float min = 14;
            float max = 30;
            float range = max - min;
            float sample = (float)ran.NextDouble();
            float scaled = (sample * range) + min;
            x = Math.Round(scaled, 2);
            if (brojSobe < 1 || brojSobe > 5)
                label8.Text = imeSobe;
            else
            {
                soba = sveSobe.Find(s => s.SobaID == brojSobe);
                label8.Text = soba.NazivSobe;
            }

            if (x > 25)
            {
                celzijusBox.BackColor = System.Drawing.Color.IndianRed;
                farenhajtBox.BackColor = System.Drawing.Color.IndianRed;
                alarmZvuk.Visible = true;
                podatak.StatusAlarma = "ON";
            }
            else if (x < 18)
            {
                celzijusBox.BackColor = System.Drawing.Color.PaleTurquoise;
                farenhajtBox.BackColor = System.Drawing.Color.PaleTurquoise;
                alarmZvuk.Visible = true;
                podatak.StatusAlarma = "ON";
            }
            else
            {
                celzijusBox.BackColor = System.Drawing.Color.White;
                farenhajtBox.BackColor = System.Drawing.Color.White;
                alarmZvuk.Visible = false;
                button1.Visible = false;
                podatak.StatusAlarma = "OFF";

            }
            celzijusBox.Text = x + "C";
            farenhajtBox.Text = x * 1.8 + 32 + "F";

            podatak.Vrijeme = DateTime.Now;
            if (brojSobe < 1 || brojSobe > 5)
                podatak.SobaID = 1;
            else
                podatak.SobaID = brojSobe;
            podatak.TemperaturaCelzijusa = ToSingle(x);
            podatak.TemperaturaFarenhajta = ((float)(ToSingle(x) * 1.8 + 32));

            myContext.podaci.Add(podatak);
            myContext.SaveChanges();
        }
        private void Početna_Load(object sender, EventArgs e, int brojSobe=1)
        {
            
            MyContext myContext = new MyContext();
            sobe soba = new sobe();
            sveSobe = myContext.sobe.ToList();
            Random ran = new Random();
            podaci podatak = new podaci();
            button1.Visible = true;
            float min = 14;
            float max = 30;
            float range = max - min;
            float sample = (float)ran.NextDouble();
            float scaled = (sample * range) + min;
            x = Math.Round(scaled, 2);
            if (brojSobe < 1 || brojSobe > 5)
                label8.Text = imeSobe;
            else
            {
                soba = sveSobe.Find(s => s.SobaID == brojSobe);
                label8.Text = soba.NazivSobe;
            }

            if (x > 25)
            {
                celzijusBox.BackColor = System.Drawing.Color.IndianRed;
                farenhajtBox.BackColor = System.Drawing.Color.IndianRed;
                alarmZvuk.Visible = true;
                podatak.StatusAlarma = "ON";
            }
            else if (x<18)
            {
                celzijusBox.BackColor = System.Drawing.Color.PaleTurquoise;
                farenhajtBox.BackColor = System.Drawing.Color.PaleTurquoise;
                alarmZvuk.Visible = true;
                podatak.StatusAlarma = "ON";
            }
            else
            {
                celzijusBox.BackColor = System.Drawing.Color.White;
                farenhajtBox.BackColor = System.Drawing.Color.White;
                alarmZvuk.Visible = false;
                button1.Visible = false;
                podatak.StatusAlarma = "OFF";

            }
            celzijusBox.Text = x +"C";
            farenhajtBox.Text = x * 1.8 + 32 + "F";

            podatak.Vrijeme = DateTime.Now;
            if (brojSobe < 1 || brojSobe > 5)
                podatak.SobaID = 1;
            else
                podatak.SobaID = brojSobe;
            podatak.TemperaturaCelzijusa = ToSingle(x);
            podatak.TemperaturaFarenhajta = ((float)(ToSingle(x) * 1.8 + 32));

            myContext.podaci.Add(podatak);
            myContext.SaveChanges();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Arduino arduino = new Arduino();
            Arduino.instanca.ardBox.Text= x + "C " + (x * 1.8 + 32) + "F";
            if(x > 25 || x < 18)
            {

                Arduino.instanca.buzEmit.Visible = true;

            }
            else
            {
                Arduino.instanca.buzEmit.Visible = false;
            }
            arduino.Show();
        }

        private void alarmZvuk_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            sobe soba = new sobe();
            OdabirSobe odabir = new OdabirSobe();
            MyContext my = new MyContext();
            sveSobe = my.sobe.ToList();
            if (odabir.ShowDialog() ==DialogResult.OK)
            {
                if (odabir.VrijednostZaSobu < 1 || odabir.VrijednostZaSobu> 5)
                    label8.Text = imeSobe;
                else
                {
                    soba = sveSobe.Find(s => s.SobaID == odabir.VrijednostZaSobu);
                    label8.Text = soba.NazivSobe;
                }
            }
            odabir.Hide();
            instanca.Početna_Load(sender, e, brojSobe=odabir.VrijednostZaSobu);

        }
    }
}
