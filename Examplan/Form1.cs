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

namespace Examplan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2(this, 0);
            f2.Show();
        }


        private void openbutton_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2(this, 1);
            f2.Show();
        }
    }
}
