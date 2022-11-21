using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrgaHackat
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void btn_hackathons_Click(object sender, EventArgs e)
        {
            hackathons Form1 = new hackathons();
            Form1.Show();
            this.Hide();
        }
    }
}