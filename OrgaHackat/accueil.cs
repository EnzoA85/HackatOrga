<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
=======
using OrgaHackat.Models;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
>>>>>>> 80afc93db02212b02c9f5eb442109c1b113646bb

namespace OrgaHackat
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btn_hackathons_Click(object sender, EventArgs e)
        {
            hackathons Form1 = new hackathons();
            Form1.Show();
            this.Hide();
        }
=======
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

        private void btnImprimer_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 80afc93db02212b02c9f5eb442109c1b113646bb
    }
}