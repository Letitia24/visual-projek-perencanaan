using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_projek_perencanaan
{
    public partial class Masuk : Form
    {
        public Masuk()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input_data utama = new input_data();
            utama.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view utama = new view();
            utama.Show();
            this.Hide();
        }
    }
}
