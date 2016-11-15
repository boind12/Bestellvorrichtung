using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_kaufen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public ArrayList Auto_List = new ArrayList();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButton1.Checked==true)
                {
                    PKW pkw = new PKW();
                    pkw.name = textBox1.Text;
                    pkw.PS = Convert.ToInt32(textBox2.Text);
                    pkw.kilometerstand = Convert.ToInt32(textBox3.Text);
                    pkw.verbrauch = Convert.ToDouble(textBox4.Text);
                    pkw.tankinhalt = Convert.ToInt32(textBox5.Text);
                    pkw.personenzahl = Convert.ToInt32(textBox6.Text);
                    Auto_List.Add(pkw);
                }
                else
                {
                    LKW lkw = new LKW();
                    lkw.name = textBox11.Text;
                    lkw.PS = Convert.ToInt32(textBox12.Text);
                    lkw.kilometerstand = Convert.ToInt32(textBox10.Text);
                    lkw.verbrauch = Convert.ToDouble(textBox9.Text);
                    lkw.tankinhalt = Convert.ToInt32(textBox8.Text);
                    lkw.Zuladung_Max = Convert.ToInt32(textBox7.Text);
                    Auto_List.Add(lkw);
                }
                refresh_listbox();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void refresh_listbox()
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Art: \t Name \t PS: \t Kilometerstand:");
                foreach (object x in Auto_List)
                {
                    if (x is PKW)
                    {
                        PKW tmp = (PKW)x;
                        listBox1.Items.Add("PKW: \t" + tmp.name + " \t" + tmp.PS + "PS \t" + tmp.kilometerstand);
                        listBox1.Refresh();
                    }
                    else if (x is LKW)
                    {
                        LKW tmp = (LKW)x;
                        listBox1.Items.Add("LKW: \t" + tmp.name + " \t" + tmp.PS + "PS \t" + tmp.kilometerstand);
                        listBox1.Refresh();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] bekannt;
            var list = (ListBox)sender;
            int itemIndex = list.IndexFromPoint(e.Location);
            if (listBox1.SelectedItem != null)
            {
                string unbekannt = listBox1.SelectedItem.ToString();
                bekannt = unbekannt.Split(' ');
                if(bekannt[0]=="PKW:")
                {
                    bildwechseln("PKW");
                    PKW tmp = (PKW)Auto_List[itemIndex - 1];
                    textBox1.Text = tmp.name;
                    textBox2.Text = tmp.PS.ToString();
                    textBox3.Text = tmp.kilometerstand.ToString();
                    textBox4.Text = tmp.verbrauch.ToString();
                    textBox5.Text = tmp.tankinhalt.ToString();
                    textBox6.Text = tmp.personenzahl.ToString();
                }
                else
                {
                    bildwechseln("LKW");
                    LKW tmp = (LKW)Auto_List[itemIndex - 1];
                    textBox11.Text = tmp.name;
                    textBox12.Text = tmp.PS.ToString();
                    textBox10.Text = tmp.kilometerstand.ToString();
                    textBox9.Text = tmp.verbrauch.ToString();
                    textBox8.Text = tmp.tankinhalt.ToString();
                    textBox7.Text = tmp.Zuladung_Max.ToString();
                }
            }

        }

        private void bildwechseln (string wasistes)
        {
            if(wasistes=="PKW")
            {
                pictureBox1.Image = Image.FromFile("m4.jpg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("lkw.jpg");
            }
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ohneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geilesMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
