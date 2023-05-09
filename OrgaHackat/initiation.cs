
using OrgaHackat.Models;


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
            var hacka = (Hackathon)cbxHackathons.SelectedItem;
            Hackathon hackathon = cnx.Hackathons.Where(nhac => nhac.Theme == hacka.Theme).Single();

            Evenement EvInitiation = new Evenement()
            {
                //Recupération des champs apres conversion en leur bon type
                HackathonId = hackathon.Id,
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
                NbPlaceLimite = Convert.ToInt32(numNbPlaces.Value)
            };
            cnx.Initiations.Add(InInitiation);
            cnx.SaveChanges();

            tbxLibelle.ResetText();
            tbxSalle.ResetText();
            numNbPlaces.ResetText();
            numDuree.ResetText();
            MessageBox.Show("Enregistré !");
        }



        private void btnretour_Click(object sender, EventArgs e)
        {
            accueil FormAccueil = new accueil();
            FormAccueil.Show();
            this.Hide();
        }
    }
}
