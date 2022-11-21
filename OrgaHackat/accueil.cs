namespace OrgaHackat
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void accueil_Load(object sender, EventArgs e)
        {

        }

        private void btn_conference_Click(object sender, EventArgs e)
        {
            enregistrerConference form = new enregistrerConference();
            form.Show();
            this.Hide();
        }
    }
}