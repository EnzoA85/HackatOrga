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
using Microsoft.EntityFrameworkCore;

namespace OrgaHackat
{
    public partial class hackathons : Form
    {
        public hackathons()
        {
            InitializeComponent();
        }
        private void hackathons_Load(object sender, EventArgs e)
        {
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();
            Hackathon newHackathon = new Hackathon()
            {
                Theme = tbx_theme_hackathon.Text,
                Description = tbx_description_hackathon.Text,
                Image = tbx_image_hackathon.Text,
                Lieu = tbx_lieu_hackathon.Text,
                Rue = tbx_rue_hackathon.Text,
                Ville = tbx_ville_hackathon.Text,
                CodePostal = tbx_cp_hackathon.Text,
                NbPlaces = npd_nbplace_hackathon.TabIndex,
                DateDebut = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datedebut_hackathon.Value)),
                DateFin = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datefin_hackathon.Value)),
                DateLimite = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datelimite_hackathon.Value)),
                HeureDebut = TimeOnly.FromDateTime(Convert.ToDateTime(dtp_heuredebut_hackathon.Value)),
                HeureFin = TimeOnly.FromDateTime(Convert.ToDateTime(dtp_heuredebut_hackathon.Value)),
            };
            if (newHackathon.Theme == "")
            {
                MessageBox.Show("Une erreur est survenue, veuillez au moins rentrer un thème");
            }
            else
            {
                cnx.Hackathons.Add(newHackathon);
                cnx.SaveChanges();
                if (cnx.Hackathons != null)
                {
                    MessageBox.Show("Hackathon ajouter");
                }
                else
                {
                    MessageBox.Show("Le hackathon n'a pas été ajouter, une erreur est survenue");
                }
            }
        }

        private void btn_retour_accueil_Click(object sender, EventArgs e)
        {
            accueil Form1 = new accueil();
            Form1.Show();
            this.Hide();
        }
    }
}
