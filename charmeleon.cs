using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_challenge_7
{
    public partial class charmeleon : Form
    {
        public charmeleon()
        {
            InitializeComponent();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            var charmeleon = new charizard();
            charmeleon.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            var charmeleon = new charmander();
            charmeleon.Show();
        }
    }
}
