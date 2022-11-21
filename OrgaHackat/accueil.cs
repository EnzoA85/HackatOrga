namespace OrgaHackat
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void btninitiation_Click(object sender, EventArgs e)
        {
            initiation Form1 = new initiation();
            Form1.Show();
            this.Hide();
        }
    }
}