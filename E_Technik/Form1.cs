using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Technik
{
    public partial class Form1 : Form
    {
        private UserControl1 R1 = new UserControl1("100");
        private Timer t1 = new Timer(); // Timer anlegen
        public Form1()
        {
            InitializeComponent();
            t1.Enabled = true;
            t1.Interval = 100; // Intervall festlegen, hier 100 ms
            t1.Tick += new EventHandler(t1_Tick); // Eventhandler ezeugen der beim Timerablauf aufgerufen wird
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pB_R1.AllowDrop = true;
            pB_R2.AllowDrop = true;
            pB_U.AllowDrop = true;
        }

        void t1_Tick(object sender, EventArgs e)
        {
            lb_RG.Text = (Convert.ToInt32(lb_R1.Text) + Convert.ToInt32(lb_R2.Text)).ToString();
        }

        private void R_100_MouseDown(object sender, MouseEventArgs e)
        {
            // Start the drag if it's the right mouse button.
            if (e.Button == MouseButtons.Right)
            {
                R_100.DoDragDrop(R_100.Image,DragDropEffects.Copy);
            }
        }

        private void pB_R1_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes an image.
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }

        private void pB_R1_DragDrop(object sender, DragEventArgs e)
        {
            pB_R1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            if (pB_R1.Image == R_100.Image)
            {
                lb_R1.Text = "100";
            }
            else if(pB_R1.Image==R_200.Image)
            {
                lb_R1.Text = "200";
            }
            else if (pB_R1.Image == R_400.Image)
            {
                lb_R1.Text = "400";
            }
        }
        private void pB_R2_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes an image.
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }

        private void pB_R2_DragDrop(object sender, DragEventArgs e)
        {
            pB_R2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            if (pB_R2.Image == R_100.Image)
            {
                lb_R2.Text = "100";
            }
            else if (pB_R2.Image == R_200.Image)
            {
                lb_R2.Text = "200";
            }
            else if (pB_R2.Image == R_400.Image)
            {
                lb_R2.Text = "400";
            }
        }

        private void pB_U_DragDrop(object sender, DragEventArgs e)
        {
            pB_U.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void pB_U_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes an image.
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            // Start the drag if it's the right mouse button.
            if (e.Button == MouseButtons.Right)
            {
                R_200.DoDragDrop(R_200.Image, DragDropEffects.Copy);
            }
        }

        private void R_400_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void R_400_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void R_400_MouseDown(object sender, MouseEventArgs e)
        {
            // Start the drag if it's the right mouse button.
            if (e.Button == MouseButtons.Right)
            {
                R_400.DoDragDrop(R_400.Image, DragDropEffects.Copy);
            }
        }
    }
}
