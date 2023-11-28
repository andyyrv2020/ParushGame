using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParushGame.View
{
    public partial class ParushFoundYou : Form
    {
        public ParushFoundYou()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            YouDiedView f = new YouDiedView();
            f.Show();
            Hide();
        }

        private void buttonFight_Click(object sender, EventArgs e)
        {
            YouDiedView f = new YouDiedView();
            f.Show();
            Hide();
        }

        private void buttonBribe_Click(object sender, EventArgs e)
        {
            BribeScreenView f = new BribeScreenView();
            f.Show();
            Hide();
        }
    }
}
