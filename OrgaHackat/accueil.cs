using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OrgaHackat.Models;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

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
        private void accueil_Load(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();
        }

        private void btn_conference_Click(object sender, EventArgs e)
        {
            enregistrerConference form = new enregistrerConference();
            form.Show();
            this.Hide();
        }

        private void btninitiation_Click(object sender, EventArgs e)
        {
            initiation Form1 = new initiation();
            Form1.Show();
            this.Hide();
        }

        private void btn_statistique_Click(object sender, EventArgs e)
        {
            statistique Form2 = new statistique();
            Form2.Show();
            this.Hide();
        }
    }
}