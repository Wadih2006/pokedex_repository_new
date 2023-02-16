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
    public partial class ivysaur : Form
    {
        public ivysaur()
        {
            InitializeComponent();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            var ivysaur = new bulbasaur();
            ivysaur.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            var ivysaur = new venusaur();
            ivysaur.Show();
        }
    }
}
