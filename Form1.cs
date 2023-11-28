using ParushGame.View;

namespace ParushGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void parushDoor_Click(object sender, EventArgs e)
        {
            ParushDesktopView f = new ParushDesktopView();
            f.Show();
            Hide();
        }
    }
}