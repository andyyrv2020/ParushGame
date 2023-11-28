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
    public partial class ParushDesktopView : Form
    {
        public ParushDesktopView()
        {
            InitializeComponent();
        }

        private void parushDesktopBtn_Click(object sender, EventArgs e)
        {
            ParushFoundYou f = new ParushFoundYou();
            f.Show();
            Hide();
        }
    }
}
