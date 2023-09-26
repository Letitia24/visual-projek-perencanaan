using System;
using System.Windows.Forms;

namespace visual_projek_perencanaan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masuk utama = new Masuk();
            utama.Show();
            this.Hide();
        }
    }
}
