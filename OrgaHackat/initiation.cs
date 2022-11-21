using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrgaHackat
{
    public partial class initiation : Form
    {
        public initiation()
        {
            InitializeComponent();
        }

        private void initiation_Load(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();
            cbxHackathons.DataSource = cnx.Hackathons.ToList();
            cbxHackathons.DisplayMember = "Theme";
            cbxHackathons.ValueMember = "Id";


        }

        private void btnCreerInitiation_Click(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();

            //(Heritage) Créer d'abord un événement puis une initiation avec la meme id
            
            Evenement EvInitiation = new Evenement()
            {
                //Recupération des champs apres conversion en leur bon type
                HackathonId = cbxHackathons.SelectedIndex,
                Libelle = tbxLibelle.Text,
                Date = DateOnly.FromDateTime(Convert.ToDateTime(dtpDate.Value)),
                Duree = Convert.ToInt32(numDuree.Value),
                Heure = TimeOnly.FromDateTime(Convert.ToDateTime(dtpHeure.Value)),
                Salle = tbxSalle.Text,
                Type = "init" // le type pour symfony
            };
            cnx.Evenements.Add(EvInitiation);
            cnx.SaveChanges();

            //Créer une initiation avec la meme id
            Initiation InInitiation = new Initiation()
            {
                Id = EvInitiation.Id,
                NbPlaceLimite = Convert.ToInt32(numDuree.Value)
            };
            cnx.Initiations.Add(InInitiation);
            cnx.SaveChanges();
        }
    }
}
