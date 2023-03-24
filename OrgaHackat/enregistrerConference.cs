using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using OrgaHackat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            cbxIntervenant.DisplayMember = "Nom";
            cbxIntervenant.ValueMember = "Id";
            //clbConferences.DataSource = cnx.Conferences.ToList();
            clbConferences.DataSource = cnx.Conferences.Where(conf => conf.IdNavigation.Date <= DateOnly.FromDateTime(DateTime.Now.AddDays(7).Date)).ToList();
            clbConferences.DisplayMember = "Theme";
            clbConferences.ValueMember = "Id";
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

            if (tbxLibelle.Text == "")
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "libelle de l'evenement est vide !";
            }
            else if (numDuree.Value == 0)
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

        private void cbxListeConferences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();


            foreach (Conference conf in clbConferences.CheckedItems)
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("hackathon.sio2@gmail.com"));
                email.To.Add(MailboxAddress.Parse(conf.Intervenant.Mail));
                Evenement ev = (Evenement)cnx.Evenements.Where(evn => evn.Id == conf.Id).Single();
                email.Subject = "Email de rappel pour la conférence " + ev.Libelle;
                Hackathon hackathon = (Hackathon)cnx.Hackathons.Where(hac => hac.Id == ev.HackathonId).Single();

                email.Body = new TextPart(TextFormat.Plain)
                {
                    Text = "Rappel pour votre conference sur le thème de " + conf.Theme + "\n\n" +
                    "Adresse : " + hackathon.Rue + ", " + hackathon.Ville + " " + hackathon.CodePostal + " " +
                    hackathon.Lieu + "\n" +
                    "Salle : " + ev.Salle + "\n" +
                    "à " + ev.Date + ":" + ev.Heure + " pendant " + ev.Duree + "min"
                };
                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                smtp.Connect("smtp.ac-nantes.fr", 465, SecureSocketOptions.SslOnConnect);
                //smtp.Authenticate("hackathon.sio2@outlook.com", "hackathon1");
                //smtp.Timeout = 200;
                smtp.Send(email);
                smtp.Disconnect(true);
            }




            string from = "hackathon.sio2@gmail.com";
            string to = "hackathon.sio2@gmail.com";


            /*// send email
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.ac-nantes.fr", 465, SecureSocketOptions.SslOnConnect);
            //smtp.Authenticate("hackathon.sio2@outlook.com", "hackathon1");
            //smtp.Timeout = 200;
            smtp.Send(email);
            smtp.Disconnect(true);*/


            /*using (SmtpClient client = new SmtpClient("smtp.ac-nantes.fr"))
            {
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Hello World";
                message.Body = "Salut, comment ça va ?";
                message.IsBodyHtml = false;
                //client.Host = "smtp.gmail.com";
                client.Port = 465;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential("hackathon.sio2@outlook.com", "hackathon1");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(message);
            }*/
            //MessageBox.Show("réussi");
        }
    }
}
