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
            bddboudero5Context cnx = new bddboudero5Context();
            cbx_choixHackathon.DataSource = cnx.Hackathons.ToList();
            cbx_choixHackathon.DisplayMember = "Theme";
            cbx_choixHackathon.ValueMember = "Id";
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
                NbPlaces = Convert.ToInt32(npd_nbplace_hackathon),
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
                    tbx_theme_hackathon.Text = "";
                    tbx_description_hackathon.Text = "";
                    tbx_image_hackathon.Text = "";
                    tbx_lieu_hackathon.Text = "";
                    tbx_rue_hackathon.Text = "";
                    tbx_ville_hackathon.Text = "";
                    tbx_cp_hackathon.Text = "";
                    npd_nbplace_hackathon.TabIndex = 0;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_choixHackathon.SelectedIndex != 0)
            {
                bddboudero5Context cnx = new bddboudero5Context();
                //On récupère le Hackathon choisi dans la liste
                Hackathon unHackathon = (Hackathon)cbx_choixHackathon.SelectedItem;
                tbx_theme_edit_hackathon.Text = unHackathon.Theme;
                tbx_image_edit_hackathon.Text = unHackathon.Image;
                tbx_rue_edit_hackathon.Text = unHackathon.Rue;
                tbx_ville_edit_hackathon.Text = unHackathon.Ville;
                tbx_cp_edit_hackathon.Text = unHackathon.CodePostal;
                tbx_lieu_edit_hackathon.Text = unHackathon.Lieu;
                tbx_description_edit_hackathon.Text = unHackathon.Description;
                nud_nbplace_edit_hackathon.Value = Convert.ToDecimal(unHackathon.NbPlaces);
                dtp_datedebut_edit_hackathon.Value = unHackathon.DateDebut.ToDateTime(TimeOnly.Parse("10:00 PM"));
                dtp_datefin_edit_hackathon.Value = unHackathon.DateFin.ToDateTime(TimeOnly.Parse("10:00 PM"));
                dtp_datelimite_edit_hackathon.Value = unHackathon.DateLimite.ToDateTime(TimeOnly.Parse("10:00 PM"));
                dtp_heuredebut_edit_hackathon.Value = Convert.ToDateTime(unHackathon.HeureDebut.ToShortTimeString());
                dtp_heurefin_edit_hackathon.Value = Convert.ToDateTime(unHackathon.HeureFin.ToShortTimeString());
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();
            Hackathon hackathonchoisit = (Hackathon)cbx_choixHackathon.SelectedItem;
            int idhackathon = hackathonchoisit.Id;
            Hackathon hackathonedit = cnx.Hackathons.Find(idhackathon);
            {
                hackathonedit.Theme = tbx_theme_hackathon.Text;
                hackathonedit.Description = tbx_description_hackathon.Text;
                hackathonedit.Image = tbx_image_hackathon.Text;
                hackathonedit.Lieu = tbx_lieu_hackathon.Text;
                hackathonedit.Rue = tbx_rue_hackathon.Text;
                hackathonedit.Ville = tbx_ville_hackathon.Text;
                hackathonedit.CodePostal = tbx_cp_hackathon.Text;
                hackathonedit.NbPlaces = (int?)Convert.ToDecimal(npd_nbplace_hackathon.Value);
                hackathonedit.DateDebut = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datedebut_hackathon.Value));
                hackathonedit.DateFin = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datefin_hackathon.Value));
                hackathonedit.DateLimite = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datelimite_hackathon.Value));
                hackathonedit.HeureDebut = TimeOnly.FromDateTime(Convert.ToDateTime(dtp_heuredebut_hackathon.Value));
                hackathonedit.HeureFin = TimeOnly.FromDateTime(Convert.ToDateTime(dtp_heuredebut_hackathon.Value));
                cnx.Hackathons.Update(hackathonedit);
                cnx.SaveChanges();
                if (cnx.Hackathons != null)
                {
                    MessageBox.Show("Hackathon modifier");
                }
                else
                {
                    MessageBox.Show("Le hackathon n'a pas été modifier, une erreur est survenue");
                }
            };
        }
    }
}
