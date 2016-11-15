using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_als_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pB_m_skinny.Image = Image.FromFile("m_skinny.jpg");
            txt_Weight.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    try
                    {
                        c.BackColor = System.Drawing.Color.White;
                        Convert.ToDouble(c.Text);
                    }
                    catch (DivideByZeroException error_zero)
                    {
                        MessageBox.Show("Fehler: " + error_zero.Message);
                    }
                    catch (Exception error)
                    {

                        MessageBox.Show("Fehler: " + error.Message);
                        c.Text = "";
                        c.BackColor = System.Drawing.Color.Red;
                        check = false;
                    }
                }
                if(c is ComboBox)
                {
                    c.BackColor = System.Drawing.Color.White;
                    if (c.Text!= "m" && c.Text!="w")
                    {
                        MessageBox.Show("Geben Sie Ihr Geschlecht an.");
                        c.BackColor = System.Drawing.Color.Red;
                    }
                }
            }

            if (check==true)
            {
                double size = Convert.ToDouble(txt_Size.Text), weight = Convert.ToDouble(txt_Weight.Text), double_bmi = 0;
                double_bmi = weight / (size * size);

                if (cB_Sex.SelectedText == "m")
                {
                    if (double_bmi < 18.5)
                    {
                        lbl_Ergebniss_Text.Text = ("Sie haben Untergewicht");
                        pB_m_skinny.Visible = true;

                    }
                    else if (double_bmi > 18.5 && double_bmi < 25)
                    {
                        lbl_Ergebniss_Text.Text = ("Sie haben Normalgewicht");
                        pB_m_normal.Visible = true;
                    }
                    else
                    {
                        lbl_Ergebniss_Text.Text = ("Sie sind Übergewichtig. Genauer haben Sie: ");
                        pB_m_dick.Visible = true;

                        if (double_bmi < 30)
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Präadispositas");
                        }
                        else if (double_bmi >= 30 && double_bmi < 35)
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Adipositas Grad I");
                        }
                        else if (double_bmi >= 35 && double_bmi < 40)
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Adipositas Grad II");
                        }
                        else
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Adipositas Grad III");
                        }
                    }
                }
                else
                {
                    if (double_bmi < 17.5)
                    {
                        lbl_Ergebniss_Text.Text = ("Sie haben Untergewicht");
                    }
                    else if (double_bmi > 17.5 && double_bmi < 24)
                    {
                        lbl_Ergebniss_Text.Text = ("Sie haben Normalgewicht");
                    }
                    else
                    {
                        lbl_Ergebniss_Text.Text = ("Sie sind Übergewichtig. Genauer haben Sie: ");
                        if (double_bmi < 29)
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Präadispositas");
                        }
                        else if (double_bmi >= 29 && double_bmi < 34)
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Adipositas Grad I");
                        }
                        else if (double_bmi >= 34 && double_bmi < 39)
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Adipositas Grad II");
                        }
                        else
                        {
                            lbl_Ergebniss_Text.Text = lbl_Ergebniss_Text.Text + ("Adipositas Grad III");

                        }


                    }
                }
                lbl_BMI_Text.Text = ("" + String.Format("{0:00.0}", double_bmi)); 
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
