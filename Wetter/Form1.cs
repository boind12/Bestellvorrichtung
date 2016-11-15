using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wetter
{
    public partial class Form1 : Form
    {
        private List<string> listA = new List<string>();
        private List<string> listB = new List<string>();
        private List<string> listC = new List<string>();
        private List<string> listD = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader(File.OpenRead(@"S:\Christian-Esser\Block 5\AEW\Wetter\Wetter\bin\Debug\wetter.csv"));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listA.Add(values[0]);
                listB.Add(values[1]);
                listC.Add(values[3]);
                listD.Add(values[4]);
            }

            BindingSource theBindingSource = new BindingSource();
            theBindingSource.DataSource = listB;
            comboBox1.DataSource = theBindingSource.DataSource;


            //Draw Chart
            int size = listB.Count;
            for (int i = 0; i < size; i++)
            {
                chart1.Series["Series1"].Points.AddXY(listB[i], listD[i]);

            }
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["Series1"].Color = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string datum = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            int index = listB.FindIndex(x => x.StartsWith(datum));
            textBox1.Text = listD[index];
        }
    }
}
