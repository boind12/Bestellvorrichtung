using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        private Timer t1 = new Timer(); // Timer anlegen
        private Boolean on = false;
        public Form1()
        {
            InitializeComponent();
            t1.Interval = 500; // Intervall festlegen, hier 100 ms
            t1.Tick += new EventHandler(t1_Tick); // Eventhandler ezeugen der beim Timerablauf aufgerufen wird
            t1.Stop();
            bT_on.Focus();
        }

        void t1_Tick(object sender, EventArgs e)
        {
            txt_Output.Focus();
            if (txt_Output.Text.Length==0)
            {
                txt_Output.SelectionStart = 0;
            }
            else
            {
                txt_Output.SelectionStart = txt_Output.Text.Length;
            }
            txt_Output.SelectionLength = 0;
        }


        private bool klammerauf = false;
        private bool klammerzu = false;

        private void bT_0_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "0";
        }

        private void bT_1_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "1";
        }

        private void bT_3_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "3";
        }

        private void bT_2_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "2";
        }

        private void bT_4_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "4";
        }

        private void bT_5_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "5";
        }

        private void bT_6_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "6";
        }

        private void bT_7_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "7";
        }

        private void bT_8_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "8";
        }

        private void bT_9_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + "9";
        }

        private void bT_Punkt_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + ",";
        }

        private void bT_Plus_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + " + ";
        }

        private void bT_Mal_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + " * ";
        }

        private void bT_Geteilt_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + " / ";
        }

        private void bT_Minus_Click(object sender, EventArgs e)
        {
            txt_Output.Text = txt_Output.Text + " - ";
        }

        private void bT_Gleich_Click(object sender, EventArgs e)
        {
            string Eingabe = txt_Output.Text;
            string[] EingabeString;
            int length = 0, i = 0, start = 0, ende = 0, border = 0;
            double output = 0.0, tmp=0.0;
            try
            {
                EingabeString = Eingabe.Split(' ');
                length = EingabeString.Length;
                ende = length;
                while(i<length)
                {
                    if(EingabeString[i]=="(")
                    {
                        start = i;
                    }
                    else if(EingabeString[i]==")")
                    {
                        ende = i;
                    }
                    i++;
                }
                i = start+1;
                border = ende;
                while(i<(border))
                {
                    if (i == 0 || i == start+1)
                    {
                        switch (EingabeString[i + 1])
                        {
                            case "+":
                                output = Convert.ToDouble(EingabeString[i]) + Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "-":
                                output = Convert.ToDouble(EingabeString[i]) - Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "*":
                                output = Convert.ToDouble(EingabeString[i]) * Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "/":
                                output = Convert.ToDouble(EingabeString[i]) / Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (EingabeString[i + 1])
                        {
                            case "+":
                                output = output + Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "-":
                                output = output - Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "*":
                                output = output * Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "/":
                                output = output / Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            default:
                                break;
                        }
                    }
                    i += 2;
                }
                if(start==0)
                 {
                    i = ende;
                    while(i<length-1)
                    {
                        switch (EingabeString[i + 1])
                        {
                            case "+":
                                output = output + Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "-":
                                output = output - Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "*":
                                output = output * Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            case "/":
                                output = output / Convert.ToDouble(EingabeString[i + 2]);
                                break;
                            default:
                                break;
                        }
                        i += 2;
                    }
                 }
                else if (ende == length - 1)
                {
                    i = 0;
                    while (i < start-1)
                    {
                        if(i==0)
                        {
                            switch (EingabeString[i + 1])
                            {
                                case "+":
                                    tmp = Convert.ToDouble(EingabeString[i]) + Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                case "-":
                                    tmp = Convert.ToDouble(EingabeString[i]) - Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                case "*":
                                    tmp = Convert.ToDouble(EingabeString[i]) * Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                case "/":
                                    tmp = Convert.ToDouble(EingabeString[i]) / Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if(i==start-2)
                        {
                            switch (EingabeString[i + 1])
                            {
                                case "+":
                                    output = tmp + output;
                                    break;
                                case "-":
                                    output = tmp - output;
                                    break;
                                case "*":
                                    output = tmp * output; ;
                                    break;
                                case "/":
                                    output = tmp - output; ;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (EingabeString[i + 1])
                            {
                                case "+":
                                    tmp = tmp + Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                case "-":
                                    tmp = tmp - Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                case "*":
                                    tmp = tmp * Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                case "/":
                                    tmp = tmp / Convert.ToDouble(EingabeString[i + 2]);
                                    break;
                                default:
                                    break;
                            }
                        }
                        i += 2;
                    }
                }
                txt_Output.Text = output.ToString();
            }
            catch(Exception error)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten: " + error.Message);
            }
        }

        private void bT_AC_Click(object sender, EventArgs e)
        {
            txt_Output.Text = "";
            klammerauf = false;
            klammerzu = false;
        }

        private void bT_KlammerAuf_Click(object sender, EventArgs e)
        {
            if (klammerauf == true)
            {
                MessageBox.Show("Diese Programm kann bis jezt nur eine Klammer öffnen!");
            }
            else
            {

                txt_Output.Text = txt_Output.Text + "( ";
                klammerauf = true;
            }


        }

        private void bT_KlammerZu_Click(object sender, EventArgs e)
        {
            if(klammerzu==true)
            {
                MessageBox.Show("Diese Programm kann bis jezt nur eine Klammer schließen!");
            }
            else
            {

                txt_Output.Text = txt_Output.Text + " )";
                klammerzu = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bT_on_Click(object sender, EventArgs e)
        {
            if(on==true)
            {
                on = false;
                t1.Stop();
                tB_onoff.Visible = true;
            }
            else
            {
                on = true;
                t1.Start(); // Timer starten
                tB_onoff.Visible = false;
            }          
        }
    }
}
