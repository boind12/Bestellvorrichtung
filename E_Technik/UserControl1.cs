using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Technik
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string widerstand)
        {
            InitializeComponent();
            Widerstand.Text = widerstand;
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
