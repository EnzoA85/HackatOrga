namespace OrgaHackat
{
    partial class hackathons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbc_hackathons = new System.Windows.Forms.TabControl();
            this.ajouterHackathon = new System.Windows.Forms.TabPage();
            this.gbx_horaire_hackathon = new System.Windows.Forms.GroupBox();
            this.dtp_heurefin_hackathon = new System.Windows.Forms.DateTimePicker();
            this.dtp_heuredebut_hackathon = new System.Windows.Forms.DateTimePicker();
            this.dtp_datefin_hackathon = new System.Windows.Forms.DateTimePicker();
            this.dtp_datedebut_hackathon = new System.Windows.Forms.DateTimePicker();
            this.lbl_heureFin_hackathon = new System.Windows.Forms.Label();
            this.lbl_heureDebut_hackathon = new System.Windows.Forms.Label();
            this.lbl_dateFin_hackathon = new System.Windows.Forms.Label();
            this.lbl_horaire_hackathon = new System.Windows.Forms.Label();
            this.lbl_dateDebut_hackathon = new System.Windows.Forms.Label();
            this.gbx_adresse_hackathon = new System.Windows.Forms.GroupBox();
            this.tbx_lieu_hackathon = new System.Windows.Forms.TextBox();
            this.tbx_cp_hackathon = new System.Windows.Forms.TextBox();
            this.tbx_ville_hackathon = new System.Windows.Forms.TextBox();
            this.tbx_rue_hackathon = new System.Windows.Forms.TextBox();
            this.lbl_adresse_hackathon = new System.Windows.Forms.Label();
            this.lbl_lieu_hackathon = new System.Windows.Forms.Label();
            this.lbl_rue_hackathon = new System.Windows.Forms.Label();
            this.lbl_ville_hackathon = new System.Windows.Forms.Label();
            this.lbl_cp_hackathon = new System.Windows.Forms.Label();
            this.gbx_informations_hackathon = new System.Windows.Forms.GroupBox();
            this.dtp_datelimite_hackathon = new System.Windows.Forms.DateTimePicker();
            this.lbl_datelimite_hackathon = new System.Windows.Forms.Label();
            this.npd_nbplace_hackathon = new System.Windows.Forms.NumericUpDown();
            this.tbx_image_hackathon = new System.Windows.Forms.TextBox();
            this.lbl_image_hackathon = new System.Windows.Forms.Label();
            this.tbx_description_hackathon = new System.Windows.Forms.TextBox();
            this.tbx_theme_hackathon = new System.Windows.Forms.TextBox();
            this.lbl_informations_hackathon = new System.Windows.Forms.Label();
            this.lbl_theme_hackathon = new System.Windows.Forms.Label();
            this.lbl_description_hackathon = new System.Windows.Forms.Label();
            this.lbl_nbPlace_hackathons = new System.Windows.Forms.Label();
            this.btn_ajouter_hackathon = new System.Windows.Forms.Button();
            this.editHackathon = new System.Windows.Forms.TabPage();
            this.btn_retour_accueil = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbc_hackathons.SuspendLayout();
            this.ajouterHackathon.SuspendLayout();
            this.gbx_horaire_hackathon.SuspendLayout();
            this.gbx_adresse_hackathon.SuspendLayout();
            this.gbx_informations_hackathon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npd_nbplace_hackathon)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_hackathons
            // 
            this.tbc_hackathons.Controls.Add(this.ajouterHackathon);
            this.tbc_hackathons.Controls.Add(this.editHackathon);
            this.tbc_hackathons.Location = new System.Drawing.Point(12, 3);
            this.tbc_hackathons.Name = "tbc_hackathons";
            this.tbc_hackathons.SelectedIndex = 0;
            this.tbc_hackathons.Size = new System.Drawing.Size(776, 428);
            this.tbc_hackathons.TabIndex = 0;
            // 
            // ajouterHackathon
            // 
            this.ajouterHackathon.Controls.Add(this.gbx_horaire_hackathon);
            this.ajouterHackathon.Controls.Add(this.gbx_adresse_hackathon);
            this.ajouterHackathon.Controls.Add(this.gbx_informations_hackathon);
            this.ajouterHackathon.Controls.Add(this.btn_ajouter_hackathon);
            this.ajouterHackathon.Location = new System.Drawing.Point(4, 24);
            this.ajouterHackathon.Name = "ajouterHackathon";
            this.ajouterHackathon.Padding = new System.Windows.Forms.Padding(3);
            this.ajouterHackathon.Size = new System.Drawing.Size(768, 400);
            this.ajouterHackathon.TabIndex = 0;
            this.ajouterHackathon.Text = "Ajouter";
            this.ajouterHackathon.UseVisualStyleBackColor = true;
            // 
            // gbx_horaire_hackathon
            // 
            this.gbx_horaire_hackathon.Controls.Add(this.dtp_heurefin_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.dtp_heuredebut_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.dtp_datefin_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.dtp_datedebut_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.lbl_heureFin_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.lbl_heureDebut_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.lbl_dateFin_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.lbl_horaire_hackathon);
            this.gbx_horaire_hackathon.Controls.Add(this.lbl_dateDebut_hackathon);
            this.gbx_horaire_hackathon.Location = new System.Drawing.Point(6, 256);
            this.gbx_horaire_hackathon.Name = "gbx_horaire_hackathon";
            this.gbx_horaire_hackathon.Size = new System.Drawing.Size(459, 138);
            this.gbx_horaire_hackathon.TabIndex = 13;
            this.gbx_horaire_hackathon.TabStop = false;
            // 
            // dtp_heurefin_hackathon
            // 
            this.dtp_heurefin_hackathon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_heurefin_hackathon.Location = new System.Drawing.Point(354, 102);
            this.dtp_heurefin_hackathon.Name = "dtp_heurefin_hackathon";
            this.dtp_heurefin_hackathon.Size = new System.Drawing.Size(79, 23);
            this.dtp_heurefin_hackathon.TabIndex = 20;
            // 
            // dtp_heuredebut_hackathon
            // 
            this.dtp_heuredebut_hackathon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_heuredebut_hackathon.Location = new System.Drawing.Point(354, 53);
            this.dtp_heuredebut_hackathon.Name = "dtp_heuredebut_hackathon";
            this.dtp_heuredebut_hackathon.Size = new System.Drawing.Size(79, 23);
            this.dtp_heuredebut_hackathon.TabIndex = 14;
            // 
            // dtp_datefin_hackathon
            // 
            this.dtp_datefin_hackathon.Location = new System.Drawing.Point(113, 104);
            this.dtp_datefin_hackathon.Name = "dtp_datefin_hackathon";
            this.dtp_datefin_hackathon.Size = new System.Drawing.Size(106, 23);
            this.dtp_datefin_hackathon.TabIndex = 19;
            // 
            // dtp_datedebut_hackathon
            // 
            this.dtp_datedebut_hackathon.Location = new System.Drawing.Point(113, 53);
            this.dtp_datedebut_hackathon.Name = "dtp_datedebut_hackathon";
            this.dtp_datedebut_hackathon.Size = new System.Drawing.Size(106, 23);
            this.dtp_datedebut_hackathon.TabIndex = 13;
            // 
            // lbl_heureFin_hackathon
            // 
            this.lbl_heureFin_hackathon.AutoSize = true;
            this.lbl_heureFin_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_heureFin_hackathon.Location = new System.Drawing.Point(231, 106);
            this.lbl_heureFin_hackathon.Name = "lbl_heureFin_hackathon";
            this.lbl_heureFin_hackathon.Size = new System.Drawing.Size(95, 21);
            this.lbl_heureFin_hackathon.TabIndex = 14;
            this.lbl_heureFin_hackathon.Text = "Heure de fin";
            // 
            // lbl_heureDebut_hackathon
            // 
            this.lbl_heureDebut_hackathon.AutoSize = true;
            this.lbl_heureDebut_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_heureDebut_hackathon.Location = new System.Drawing.Point(231, 53);
            this.lbl_heureDebut_hackathon.Name = "lbl_heureDebut_hackathon";
            this.lbl_heureDebut_hackathon.Size = new System.Drawing.Size(117, 21);
            this.lbl_heureDebut_hackathon.TabIndex = 13;
            this.lbl_heureDebut_hackathon.Text = "Heure de début";
            // 
            // lbl_dateFin_hackathon
            // 
            this.lbl_dateFin_hackathon.AutoSize = true;
            this.lbl_dateFin_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dateFin_hackathon.Location = new System.Drawing.Point(6, 104);
            this.lbl_dateFin_hackathon.Name = "lbl_dateFin_hackathon";
            this.lbl_dateFin_hackathon.Size = new System.Drawing.Size(85, 21);
            this.lbl_dateFin_hackathon.TabIndex = 12;
            this.lbl_dateFin_hackathon.Text = "Date de fin";
            // 
            // lbl_horaire_hackathon
            // 
            this.lbl_horaire_hackathon.AutoSize = true;
            this.lbl_horaire_hackathon.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_horaire_hackathon.Location = new System.Drawing.Point(171, 11);
            this.lbl_horaire_hackathon.Name = "lbl_horaire_hackathon";
            this.lbl_horaire_hackathon.Size = new System.Drawing.Size(84, 30);
            this.lbl_horaire_hackathon.TabIndex = 11;
            this.lbl_horaire_hackathon.Text = "Horaire";
            // 
            // lbl_dateDebut_hackathon
            // 
            this.lbl_dateDebut_hackathon.AutoSize = true;
            this.lbl_dateDebut_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dateDebut_hackathon.Location = new System.Drawing.Point(6, 53);
            this.lbl_dateDebut_hackathon.Name = "lbl_dateDebut_hackathon";
            this.lbl_dateDebut_hackathon.Size = new System.Drawing.Size(107, 21);
            this.lbl_dateDebut_hackathon.TabIndex = 10;
            this.lbl_dateDebut_hackathon.Text = "Date de début";
            // 
            // gbx_adresse_hackathon
            // 
            this.gbx_adresse_hackathon.Controls.Add(this.tbx_lieu_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.tbx_cp_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.tbx_ville_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.tbx_rue_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.lbl_adresse_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.lbl_lieu_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.lbl_rue_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.lbl_ville_hackathon);
            this.gbx_adresse_hackathon.Controls.Add(this.lbl_cp_hackathon);
            this.gbx_adresse_hackathon.Location = new System.Drawing.Point(471, 6);
            this.gbx_adresse_hackathon.Name = "gbx_adresse_hackathon";
            this.gbx_adresse_hackathon.Size = new System.Drawing.Size(272, 249);
            this.gbx_adresse_hackathon.TabIndex = 10;
            this.gbx_adresse_hackathon.TabStop = false;
            // 
            // tbx_lieu_hackathon
            // 
            this.tbx_lieu_hackathon.Location = new System.Drawing.Point(134, 164);
            this.tbx_lieu_hackathon.Name = "tbx_lieu_hackathon";
            this.tbx_lieu_hackathon.Size = new System.Drawing.Size(132, 23);
            this.tbx_lieu_hackathon.TabIndex = 16;
            // 
            // tbx_cp_hackathon
            // 
            this.tbx_cp_hackathon.Location = new System.Drawing.Point(134, 131);
            this.tbx_cp_hackathon.Name = "tbx_cp_hackathon";
            this.tbx_cp_hackathon.Size = new System.Drawing.Size(132, 23);
            this.tbx_cp_hackathon.TabIndex = 15;
            // 
            // tbx_ville_hackathon
            // 
            this.tbx_ville_hackathon.Location = new System.Drawing.Point(134, 92);
            this.tbx_ville_hackathon.Name = "tbx_ville_hackathon";
            this.tbx_ville_hackathon.Size = new System.Drawing.Size(132, 23);
            this.tbx_ville_hackathon.TabIndex = 14;
            // 
            // tbx_rue_hackathon
            // 
            this.tbx_rue_hackathon.Location = new System.Drawing.Point(134, 53);
            this.tbx_rue_hackathon.Name = "tbx_rue_hackathon";
            this.tbx_rue_hackathon.Size = new System.Drawing.Size(132, 23);
            this.tbx_rue_hackathon.TabIndex = 13;
            // 
            // lbl_adresse_hackathon
            // 
            this.lbl_adresse_hackathon.AutoSize = true;
            this.lbl_adresse_hackathon.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_adresse_hackathon.Location = new System.Drawing.Point(110, 10);
            this.lbl_adresse_hackathon.Name = "lbl_adresse_hackathon";
            this.lbl_adresse_hackathon.Size = new System.Drawing.Size(88, 30);
            this.lbl_adresse_hackathon.TabIndex = 4;
            this.lbl_adresse_hackathon.Text = "Adresse";
            // 
            // lbl_lieu_hackathon
            // 
            this.lbl_lieu_hackathon.AutoSize = true;
            this.lbl_lieu_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lieu_hackathon.Location = new System.Drawing.Point(6, 166);
            this.lbl_lieu_hackathon.Name = "lbl_lieu_hackathon";
            this.lbl_lieu_hackathon.Size = new System.Drawing.Size(39, 21);
            this.lbl_lieu_hackathon.TabIndex = 3;
            this.lbl_lieu_hackathon.Text = "Lieu";
            // 
            // lbl_rue_hackathon
            // 
            this.lbl_rue_hackathon.AutoSize = true;
            this.lbl_rue_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rue_hackathon.Location = new System.Drawing.Point(6, 51);
            this.lbl_rue_hackathon.Name = "lbl_rue_hackathon";
            this.lbl_rue_hackathon.Size = new System.Drawing.Size(37, 21);
            this.lbl_rue_hackathon.TabIndex = 5;
            this.lbl_rue_hackathon.Text = "Rue";
            // 
            // lbl_ville_hackathon
            // 
            this.lbl_ville_hackathon.AutoSize = true;
            this.lbl_ville_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ville_hackathon.Location = new System.Drawing.Point(6, 90);
            this.lbl_ville_hackathon.Name = "lbl_ville_hackathon";
            this.lbl_ville_hackathon.Size = new System.Drawing.Size(40, 21);
            this.lbl_ville_hackathon.TabIndex = 6;
            this.lbl_ville_hackathon.Text = "Ville";
            // 
            // lbl_cp_hackathon
            // 
            this.lbl_cp_hackathon.AutoSize = true;
            this.lbl_cp_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cp_hackathon.Location = new System.Drawing.Point(6, 129);
            this.lbl_cp_hackathon.Name = "lbl_cp_hackathon";
            this.lbl_cp_hackathon.Size = new System.Drawing.Size(91, 21);
            this.lbl_cp_hackathon.TabIndex = 7;
            this.lbl_cp_hackathon.Text = "Code Postal";
            // 
            // gbx_informations_hackathon
            // 
            this.gbx_informations_hackathon.Controls.Add(this.dtp_datelimite_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.lbl_datelimite_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.npd_nbplace_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.tbx_image_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.lbl_image_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.tbx_description_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.tbx_theme_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.lbl_informations_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.lbl_theme_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.lbl_description_hackathon);
            this.gbx_informations_hackathon.Controls.Add(this.lbl_nbPlace_hackathons);
            this.gbx_informations_hackathon.Location = new System.Drawing.Point(6, 6);
            this.gbx_informations_hackathon.Name = "gbx_informations_hackathon";
            this.gbx_informations_hackathon.Size = new System.Drawing.Size(459, 249);
            this.gbx_informations_hackathon.TabIndex = 12;
            this.gbx_informations_hackathon.TabStop = false;
            // 
            // dtp_datelimite_hackathon
            // 
            this.dtp_datelimite_hackathon.Location = new System.Drawing.Point(174, 204);
            this.dtp_datelimite_hackathon.Name = "dtp_datelimite_hackathon";
            this.dtp_datelimite_hackathon.Size = new System.Drawing.Size(279, 23);
            this.dtp_datelimite_hackathon.TabIndex = 17;
            // 
            // lbl_datelimite_hackathon
            // 
            this.lbl_datelimite_hackathon.AutoSize = true;
            this.lbl_datelimite_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_datelimite_hackathon.Location = new System.Drawing.Point(6, 205);
            this.lbl_datelimite_hackathon.Name = "lbl_datelimite_hackathon";
            this.lbl_datelimite_hackathon.Size = new System.Drawing.Size(162, 21);
            this.lbl_datelimite_hackathon.TabIndex = 16;
            this.lbl_datelimite_hackathon.Text = "Date limite inscription";
            // 
            // npd_nbplace_hackathon
            // 
            this.npd_nbplace_hackathon.Location = new System.Drawing.Point(174, 127);
            this.npd_nbplace_hackathon.Name = "npd_nbplace_hackathon";
            this.npd_nbplace_hackathon.Size = new System.Drawing.Size(279, 23);
            this.npd_nbplace_hackathon.TabIndex = 15;
            // 
            // tbx_image_hackathon
            // 
            this.tbx_image_hackathon.Location = new System.Drawing.Point(174, 164);
            this.tbx_image_hackathon.Name = "tbx_image_hackathon";
            this.tbx_image_hackathon.Size = new System.Drawing.Size(279, 23);
            this.tbx_image_hackathon.TabIndex = 14;
            // 
            // lbl_image_hackathon
            // 
            this.lbl_image_hackathon.AutoSize = true;
            this.lbl_image_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_image_hackathon.Location = new System.Drawing.Point(6, 166);
            this.lbl_image_hackathon.Name = "lbl_image_hackathon";
            this.lbl_image_hackathon.Size = new System.Drawing.Size(53, 21);
            this.lbl_image_hackathon.TabIndex = 13;
            this.lbl_image_hackathon.Text = "Image";
            // 
            // tbx_description_hackathon
            // 
            this.tbx_description_hackathon.Location = new System.Drawing.Point(174, 88);
            this.tbx_description_hackathon.Name = "tbx_description_hackathon";
            this.tbx_description_hackathon.Size = new System.Drawing.Size(279, 23);
            this.tbx_description_hackathon.TabIndex = 11;
            // 
            // tbx_theme_hackathon
            // 
            this.tbx_theme_hackathon.Location = new System.Drawing.Point(174, 49);
            this.tbx_theme_hackathon.Name = "tbx_theme_hackathon";
            this.tbx_theme_hackathon.Size = new System.Drawing.Size(279, 23);
            this.tbx_theme_hackathon.TabIndex = 10;
            // 
            // lbl_informations_hackathon
            // 
            this.lbl_informations_hackathon.AutoSize = true;
            this.lbl_informations_hackathon.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_informations_hackathon.Location = new System.Drawing.Point(153, 10);
            this.lbl_informations_hackathon.Name = "lbl_informations_hackathon";
            this.lbl_informations_hackathon.Size = new System.Drawing.Size(136, 30);
            this.lbl_informations_hackathon.TabIndex = 8;
            this.lbl_informations_hackathon.Text = "Informations";
            // 
            // lbl_theme_hackathon
            // 
            this.lbl_theme_hackathon.AutoSize = true;
            this.lbl_theme_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_theme_hackathon.Location = new System.Drawing.Point(6, 51);
            this.lbl_theme_hackathon.Name = "lbl_theme_hackathon";
            this.lbl_theme_hackathon.Size = new System.Drawing.Size(57, 21);
            this.lbl_theme_hackathon.TabIndex = 1;
            this.lbl_theme_hackathon.Text = "Thème";
            // 
            // lbl_description_hackathon
            // 
            this.lbl_description_hackathon.AutoSize = true;
            this.lbl_description_hackathon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_description_hackathon.Location = new System.Drawing.Point(6, 90);
            this.lbl_description_hackathon.Name = "lbl_description_hackathon";
            this.lbl_description_hackathon.Size = new System.Drawing.Size(89, 21);
            this.lbl_description_hackathon.TabIndex = 2;
            this.lbl_description_hackathon.Text = "Description";
            // 
            // lbl_nbPlace_hackathons
            // 
            this.lbl_nbPlace_hackathons.AutoSize = true;
            this.lbl_nbPlace_hackathons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nbPlace_hackathons.Location = new System.Drawing.Point(6, 129);
            this.lbl_nbPlace_hackathons.Name = "lbl_nbPlace_hackathons";
            this.lbl_nbPlace_hackathons.Size = new System.Drawing.Size(129, 21);
            this.lbl_nbPlace_hackathons.TabIndex = 9;
            this.lbl_nbPlace_hackathons.Text = "Nombre de place";
            // 
            // btn_ajouter_hackathon
            // 
            this.btn_ajouter_hackathon.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ajouter_hackathon.Location = new System.Drawing.Point(563, 293);
            this.btn_ajouter_hackathon.Name = "btn_ajouter_hackathon";
            this.btn_ajouter_hackathon.Size = new System.Drawing.Size(106, 47);
            this.btn_ajouter_hackathon.TabIndex = 0;
            this.btn_ajouter_hackathon.Text = "Ajouter";
            this.btn_ajouter_hackathon.UseVisualStyleBackColor = true;
            this.btn_ajouter_hackathon.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // editHackathon
            // 
            this.editHackathon.Location = new System.Drawing.Point(4, 24);
            this.editHackathon.Name = "editHackathon";
            this.editHackathon.Padding = new System.Windows.Forms.Padding(3);
            this.editHackathon.Size = new System.Drawing.Size(768, 400);
            this.editHackathon.TabIndex = 1;
            this.editHackathon.Text = "Modifier";
            this.editHackathon.UseVisualStyleBackColor = true;
            // 
            // btn_retour_accueil
            // 
            this.btn_retour_accueil.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_retour_accueil.Location = new System.Drawing.Point(11, 437);
            this.btn_retour_accueil.Name = "btn_retour_accueil";
            this.btn_retour_accueil.Size = new System.Drawing.Size(106, 43);
            this.btn_retour_accueil.TabIndex = 1;
            this.btn_retour_accueil.Text = "Accueil";
            this.btn_retour_accueil.UseVisualStyleBackColor = true;
            this.btn_retour_accueil.Click += new System.EventHandler(this.btn_retour_accueil_Click);
            // 
            // hackathons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btn_retour_accueil);
            this.Controls.Add(this.tbc_hackathons);
            this.Name = "hackathons";
            this.Text = "hackathons";
            this.Load += new System.EventHandler(this.hackathons_Load);
            this.tbc_hackathons.ResumeLayout(false);
            this.ajouterHackathon.ResumeLayout(false);
            this.gbx_horaire_hackathon.ResumeLayout(false);
            this.gbx_horaire_hackathon.PerformLayout();
            this.gbx_adresse_hackathon.ResumeLayout(false);
            this.gbx_adresse_hackathon.PerformLayout();
            this.gbx_informations_hackathon.ResumeLayout(false);
            this.gbx_informations_hackathon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npd_nbplace_hackathon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbc_hackathons;
        private TabPage ajouterHackathon;
        private TabPage editHackathon;
        private Button btn_ajouter_hackathon;
        private Button btn_retour_accueil;
        private Label lbl_adresse_hackathon;
        private Label lbl_lieu_hackathon;
        private Label lbl_description_hackathon;
        private Label lbl_theme_hackathon;
        private Label lbl_ville_hackathon;
        private Label lbl_rue_hackathon;
        private Label lbl_cp_hackathon;
        private GroupBox gbx_horaire_hackathon;
        private Label lbl_heureFin_hackathon;
        private Label lbl_heureDebut_hackathon;
        private Label lbl_dateFin_hackathon;
        private Label lbl_horaire_hackathon;
        private Label lbl_dateDebut_hackathon;
        private GroupBox gbx_adresse_hackathon;
        private GroupBox gbx_informations_hackathon;
        private Label lbl_informations_hackathon;
        private Label lbl_nbPlace_hackathons;
        private TextBox tbx_lieu_hackathon;
        private TextBox tbx_cp_hackathon;
        private TextBox tbx_ville_hackathon;
        private TextBox tbx_rue_hackathon;
        private TextBox tbx_description_hackathon;
        private TextBox tbx_theme_hackathon;
        private DateTimePicker dtp_datefin_hackathon;
        private DateTimePicker dtp_datedebut_hackathon;
        private HelpProvider helpProvider1;
        private TextBox tbx_image_hackathon;
        private Label lbl_image_hackathon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown npd_nbplace_hackathon;
        private DateTimePicker dtp_datelimite_hackathon;
        private Label lbl_datelimite_hackathon;
        private DateTimePicker dtp_heurefin_hackathon;
        private DateTimePicker dtp_heuredebut_hackathon;
    }
}