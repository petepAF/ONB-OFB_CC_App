using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONB_OFB_CC_App
{
    public partial class Main_GUI : Form
    {
        public Main_GUI()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            using (Search_GUI form = new Search_GUI())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

    }
}