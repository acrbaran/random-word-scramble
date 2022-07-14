using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ödev
{
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }

        

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/acrbaran");
        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/acr_baran/");
        }

        private void ıconPictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.acarbaran.com");
        }

        private void ıconPictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/acrbaran");
        }
    }
}
