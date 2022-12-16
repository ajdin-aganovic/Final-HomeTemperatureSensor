using HomeTemperatureSensor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTemperatureSensor
{
    public partial class PodaciOTemperaturama : Form
    {
        public static PodaciOTemperaturama instanca;
        public PodaciOTemperaturama()
        {
            InitializeComponent();
            instanca = this;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PodaciOTemperaturama_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter
                ("SELECT * FROM podaci", "server = localhost; database = homeTemperatureSensor; Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "podaci");
            dataGridView1.DataSource = ds.Tables["podaci"].DefaultView;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
