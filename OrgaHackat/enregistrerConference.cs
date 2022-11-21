using OrgaHackat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgaHackat
{
    public partial class enregistrerConference : Form
    {
        public enregistrerConference()
        {
            InitializeComponent();
        }

        private void enregistrerConference_Load(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();

            cbxChoixDeHackaton.DataSource = cnx.Hackathons.ToList();
            cbxChoixDeHackaton.DisplayMember = "Theme";
            cbxChoixDeHackaton.ValueMember = "Id";
        }

        private void cbxChoixDeHackaton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
