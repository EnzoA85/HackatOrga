﻿using OrgaHackat.Models;
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
            cbxIntervenant.DataSource = cnx.Intervenants.ToList();
            cbxIntervenant.DisplayMember= "Nom";
            cbxIntervenant.ValueMember = "Id";
        }

        private void cbxChoixDeHackaton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();

            if(tbxLibelle.Text == "")
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "libelle de l'evenement est vide !";
            }
            else if(numDuree.Value == 0)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "durée d'evenement invalide !";
            }
            else
            {
                // creation de l'objet evenement
                Evenement evenement = new Evenement()
                {
                    HackathonId = cbxChoixDeHackaton.SelectedIndex,
                    Libelle = tbxLibelle.Text,
                    Date = DateOnly.FromDateTime(Convert.ToDateTime(dtpDate.Value)), // convertion en datetime puis date only
                    Duree = Convert.ToInt32(numDuree.Value),
                    Heure = TimeOnly.FromDateTime(Convert.ToDateTime(dtpTime.Value)), // convertion en datetime puis time only
                    Salle = tbxSalle.Text,
                    Type = "conf", // type necessaire pour la bdd et symfony
                };
                cnx.Evenements.Add(evenement);
                cnx.SaveChanges();

                // on recup l'intervenant avec l'id
                Intervenant intervenant = cnx.Intervenants.Where(id => id.Id == cbxIntervenant.SelectedIndex).Single();

                // creation de l'objet evenement
                Conference conference = new Conference()
                {
                    Id = evenement.Id,
                    Theme = tbxTheme.Text,
                    Intervenant = intervenant
                };
                cnx.Conferences.Add(conference);
                cnx.SaveChanges();

                // ajout de la conference dans la liste de l'intervenant
                intervenant.Conferences.Add(conference);
                cnx.Intervenants.Update(intervenant);

                cnx.SaveChanges();
                MessageBox.Show("Conference enregistrée !");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            accueil page = new accueil();
            page.Show();
            this.Hide();
        }
    }
}