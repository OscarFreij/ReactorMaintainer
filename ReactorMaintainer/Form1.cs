using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ReactorMaintainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            chart1.Series["Core Heat"].Points.Clear();

            chart1.Series["Core Heat"].Points.AddXY("Core 1", 1000);
            chart1.Series["Core Heat"].Points.AddXY("Core 2", 1200);
            chart1.Series["Core Heat"].Points.AddXY("Core 3", 1040);
            chart1.Series["Core Heat"].Points.AddXY("Core 4", 1046);
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
