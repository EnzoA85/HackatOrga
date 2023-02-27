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
                NbPlaces = Convert.ToInt32(npd_nbplace_hackathon.Text),
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
            npd_nbplace_edit_hackathon.Value = Convert.ToDecimal(unHackathon.NbPlaces);
            dtp_datedebut_edit_hackathon.Value = unHackathon.DateDebut.ToDateTime(TimeOnly.Parse("10:00 PM"));
            dtp_datefin_edit_hackathon.Value = unHackathon.DateFin.ToDateTime(TimeOnly.Parse("10:00 PM"));
            dtp_datelimite_edit_hackathon.Value = unHackathon.DateLimite.ToDateTime(TimeOnly.Parse("10:00 PM"));
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();
            Hackathon unHackathon = (Hackathon)cbx_choixHackathon.SelectedItem;
            unHackathon.Theme = tbx_theme_edit_hackathon.Text;
            unHackathon.Description = tbx_description_edit_hackathon.Text;
            unHackathon.Image = tbx_image_edit_hackathon.Text;
            unHackathon.Lieu = tbx_lieu_edit_hackathon.Text;
            unHackathon.Rue = tbx_rue_edit_hackathon.Text;
            unHackathon.Ville = tbx_ville_edit_hackathon.Text;
            unHackathon.CodePostal = tbx_cp_edit_hackathon.Text;
            unHackathon.NbPlaces = Convert.ToInt32(npd_nbplace_edit_hackathon.Text);
            unHackathon.DateDebut = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datedebut_edit_hackathon.Value));
            unHackathon.DateFin = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datefin_edit_hackathon.Value));
            unHackathon.DateLimite = DateOnly.FromDateTime(Convert.ToDateTime(dtp_datelimite_edit_hackathon.Value));
            unHackathon.HeureDebut = TimeOnly.FromDateTime(Convert.ToDateTime(dtp_heuredebut_edit_hackathon.Value));
            unHackathon.HeureFin = TimeOnly.FromDateTime(Convert.ToDateTime(dtp_heuredebut_edit_hackathon.Value));

            cnx.Hackathons.Update(unHackathon);
            cnx.SaveChanges();

            if (cnx.Hackathons != null)
            {
                MessageBox.Show("Hackathon modifié");
            }
            else
            {
                MessageBox.Show("Le hackathon n'a pas été modifié, une erreur est survenue");
            }
        }
    }
}
