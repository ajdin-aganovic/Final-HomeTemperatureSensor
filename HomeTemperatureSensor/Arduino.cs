using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeTemperatureSensor.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeTemperatureSensor
{
    public partial class Arduino : Form
    {
        public static Arduino instanca;
        public TextBox ardBox;
        public Label buzEmit;
        public Arduino()
        {
            InitializeComponent();
            instanca = this;
            ardBox = arduinoText;
            buzEmit = buzzerEmiter;
        }

        private void arduinoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Arduino_Load(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();
        
    }

        private void buzzerEmiter_Click(object sender, EventArgs e)
        {

        }
    }
}
