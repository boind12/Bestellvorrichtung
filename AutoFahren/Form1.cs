using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_fahren
{
    public partial class Form1 : Form
    {
        private Automobil auto = new Automobil();
        private PKW pkw = new PKW();
        private LKW lkw = new LKW();
        private Boolean PKW=true;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Shown;
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            bT_Anzeigen.PerformClick();
        }

        private void bT_Anzeigen_Click(object sender, EventArgs e)
        {

            if(PKW==true)
            {
                lB_Personen.Text = "Personen: " + pkw.personenzahl;
                lb_Kilometerstand.Text = "Kilometerstand: " + pkw.kilometerstand.ToString();
                lb_Tankinhalt.Text = "Tankinhalt: " + pkw.tankinhalt.ToString();
                lb_Verbrauch.Text = "Verbrauch: " + pkw.verbrauch.ToString() + " l/100km";
                if (pkw.kombi==true)
                {
                    lB_Kombi.Text="Kombi: Ja";
                }
                else
                {
                    lB_Kombi.Text = "Kombi: Nein";
                }
            }
            else
            {
                lB_Zuladung_Max.Text = "Maximale Zuladung: " + lkw.Zuladung_Max + "t";
                lb_Kilometerstand.Text = "Kilometerstand: " + lkw.kilometerstand.ToString();
                lb_Tankinhalt.Text = "Tankinhalt: " + lkw.tankinhalt.ToString();
                lb_Verbrauch.Text = "Verbrauch: " + lkw.verbrauch.ToString() + " l/100km";
                if (lkw.geladen==true)
                {
                    lb_Geladen.Text = "Ladezustand: Beladen";
                }
                else
                {
                    lb_Geladen.Text = "Ladezustand: Leer";
                }
            }
        }

        private void bt_Tanken_Click(object sender, EventArgs e)
        {
            try
            {
                if (PKW==true)
                {
                    pkw.tanken(Convert.ToInt32(tB_Tanken.Text));
                    bT_Anzeigen_Click(sender, e);
                    tB_Fahren.Text = "";
                    tB_Tanken.Text = "";
                    if (pkw.tankinhalt > 0)
                    {
                        bt_Fahren.Visible = true;
                    } 
                }
                else
                {
                    lkw.tanken(Convert.ToInt32(tB_Tanken.Text));
                    bT_Anzeigen_Click(sender, e);
                    tB_Fahren.Text = "";
                    tB_Tanken.Text = "";
                    if (lkw.tankinhalt > 0)
                    {
                        bt_Fahren.Visible = true;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bt_Fahren_Click(object sender, EventArgs e)
        {
            Boolean zuweit = false;
            try
            {
                if (PKW==true)
                {
                    zuweit = pkw.fahren(Convert.ToInt32(tB_Fahren.Text));
                    if (zuweit == false)
                    {
                        MessageBox.Show("Sie können nicht weiter fahren, als es Ihr tank zulässt. Ihr Reichweite wurde automatisch angepasst");
                    }
                    if (pkw.tankinhalt <= 0)
                    {
                        MessageBox.Show("Ihr Tank ist leer. Tanken Sie um weiter zu fahren.");
                        bt_Fahren.Visible = false;
                        pkw.tankinhalt = 0;
                        bT_Anzeigen_Click(sender, e);
                    }
                    else
                    {
                        bT_Anzeigen_Click(sender, e);
                    }
                    tB_Fahren.Text = "";
                    tB_Tanken.Text = ""; 
                }
                else
                {
                    zuweit = lkw.fahren(Convert.ToInt32(tB_Fahren.Text));
                    if (zuweit == false)
                    {
                        MessageBox.Show("Sie können nicht weiter fahren, als es Ihr tank zulässt. Ihr Reichweite wurde automatisch angepasst");
                    }
                    if (lkw.tankinhalt <= 0)
                    {
                        MessageBox.Show("Ihr Tank ist leer. Tanken Sie um weiter zu fahren.");
                        bt_Fahren.Visible = false;
                        lkw.tankinhalt = 0;
                        bT_Anzeigen_Click(sender, e);
                    }
                    else
                    {
                        bT_Anzeigen_Click(sender, e);
                    }
                    tB_Fahren.Text = "";
                    tB_Tanken.Text = "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void rB_PKW_CheckedChanged(object sender, EventArgs e)
        {
            if(PKW==true)
            {
                lb_Geladen.Visible = true;
                lB_Zuladung_Max.Visible = true;
                lB_Kombi.Visible = false;
                lB_Personen.Visible = false;
                bt_Laden.Visible = true;
                PKW = false;
                bT_Personen.Visible = false;
                txt_Personen.Visible = false;
                txt_Zuladung.Visible = true;
                bt_Zuladung.Visible = true;
                bT_Kombi.Visible = false;
                pictureBox1.Image = Image.FromFile("lkw.jpg");
                bT_Anzeigen_Click(sender, e);
            }
            else
            {
                lb_Geladen.Visible = false;
                lB_Zuladung_Max.Visible = false;
                lB_Kombi.Visible = true;
                lB_Personen.Visible = true;
                bt_Laden.Visible = false;
                PKW = true;
                bT_Personen.Visible = true;
                txt_Personen.Visible = true;
                txt_Zuladung.Visible = false;
                bt_Zuladung.Visible = false;
                bT_Kombi.Visible = true;
                if(pkw.kombi==true)
                {
                    pictureBox1.Image = Image.FromFile("kombi.jpg");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("m4.jpg");
                }
                bT_Anzeigen_Click(sender, e);
            }
        }

        private void rB_LKW_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_Laden_Click(object sender, EventArgs e)
        {
            if(bt_Laden.Text=="Laden")
            {
                lkw.geladen = true;
                bt_Laden.Text = "Entladen";
                bT_Anzeigen_Click(sender, e);
            }
            else
            {
                lkw.geladen = false;
                bt_Laden.Text = "Laden";
                bT_Anzeigen_Click(sender, e);
            }
        }

        private void bT_Kombi_Click(object sender, EventArgs e)
        {
            if (bT_Kombi.Text == "Kombi Kaufen")
            {
                pkw.kombi = true;
                pictureBox1.Image = Image.FromFile("kombi.jpg");
                bT_Kombi.Text = "Kombi verkaufen";
                bT_Anzeigen_Click(sender, e);
            }
            else
            {
                pkw.kombi = false;
                pictureBox1.Image = Image.FromFile("m4.jpg");
                bT_Kombi.Text = "Kombi Kaufen";
                bT_Anzeigen_Click(sender, e);
            }
        }

        private void bT_Personen_Click(object sender, EventArgs e)
        {
            try
            {
                pkw.personenzahl = Convert.ToInt32(txt_Personen.Text);
                bT_Anzeigen_Click(sender, e);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bt_Zuladung_Click(object sender, EventArgs e)
        {
            try
            {
                lkw.Zuladung_Max = Convert.ToInt32(txt_Zuladung.Text);
                bT_Anzeigen_Click(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            foreach (Control cnt in this.Controls)
            {
                ResizeAll(cnt, base.Size);
            }
            oldSize = base.Size;
        }
        private Size oldSize;
        private void ResizeAll(Control cnt, Size newSize)
        {
            int iWidth = newSize.Width - oldSize.Width;
            cnt.Left += (cnt.Left * iWidth) / oldSize.Width;
            cnt.Width += (cnt.Width * iWidth) / oldSize.Width;

            int iHeight = newSize.Height - oldSize.Height;
            cnt.Top += (cnt.Top * iHeight) / oldSize.Height;
            cnt.Height += (cnt.Height * iHeight) / oldSize.Height;
        }
    }
}
