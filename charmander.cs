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
    public partial class charmander : Form
    {
        public charmander()
        {
            InitializeComponent();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            var charmander = new venusaur();
            charmander.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            var charmander = new charmeleon();
            charmander.Show();
        }
    }
}
