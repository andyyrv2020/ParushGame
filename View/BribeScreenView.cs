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
    public partial class BribeScreenView : Form
    {
        public BribeScreenView()
        {
            InitializeComponent();
        }

        private void donutButton_Click(object sender, EventArgs e)
        {
            YouDiedView f = new YouDiedView();
            f.Show();
            Hide();
        }

        private void burgerButton_Click(object sender, EventArgs e)
        {
            YouDiedView f = new YouDiedView();
            f.Show();
            Hide();
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            YouWin f = new YouWin();
            f.Show();
            Hide();
        }
    }
}