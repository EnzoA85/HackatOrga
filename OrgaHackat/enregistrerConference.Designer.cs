namespace OrgaHackat
{
    partial class enregistrerConference
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
            lblMessage = new Label();
            tabConferences = new TabControl();
            tabEnregistrerConference = new TabPage();
            cbxIntervenant = new ComboBox();
            lblIntervenant = new Label();
            btnRetour = new Button();
            lblMinute = new Label();
            numDuree = new NumericUpDown();
            btnEnregistrer = new Button();
            tbxTheme = new TextBox();
            lblTheme = new Label();
            tbxSalle = new TextBox();
            lblSalle = new Label();
            dtpTime = new DateTimePicker();
            lblMin = new Label();
            lblDuree = new Label();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            tbxLibelle = new TextBox();
            lblLibelle = new Label();
            lblTitre = new Label();
            lblChoixHackaton = new Label();
            cbxChoixDeHackaton = new ComboBox();
            tabRappelConference = new TabPage();
            btnMail = new Button();
            cbxListeConferences = new ComboBox();
            labelRappelConf = new Label();
            tabConferences.SuspendLayout();
            tabEnregistrerConference.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuree).BeginInit();
            tabRappelConference.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(12, 305);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 19;
            // 
            // tabConferences
            // 
            tabConferences.Controls.Add(tabEnregistrerConference);
            tabConferences.Controls.Add(tabRappelConference);
            tabConferences.Location = new Point(12, 12);
            tabConferences.Name = "tabConferences";
            tabConferences.SelectedIndex = 0;
            tabConferences.Size = new Size(465, 408);
            tabConferences.TabIndex = 23;
            // 
            // tabEnregistrerConference
            // 
            tabEnregistrerConference.Controls.Add(cbxIntervenant);
            tabEnregistrerConference.Controls.Add(lblIntervenant);
            tabEnregistrerConference.Controls.Add(btnRetour);
            tabEnregistrerConference.Controls.Add(lblMinute);
            tabEnregistrerConference.Controls.Add(numDuree);
            tabEnregistrerConference.Controls.Add(btnEnregistrer);
            tabEnregistrerConference.Controls.Add(tbxTheme);
            tabEnregistrerConference.Controls.Add(lblTheme);
            tabEnregistrerConference.Controls.Add(tbxSalle);
            tabEnregistrerConference.Controls.Add(lblSalle);
            tabEnregistrerConference.Controls.Add(dtpTime);
            tabEnregistrerConference.Controls.Add(lblMin);
            tabEnregistrerConference.Controls.Add(lblDuree);
            tabEnregistrerConference.Controls.Add(dtpDate);
            tabEnregistrerConference.Controls.Add(lblDate);
            tabEnregistrerConference.Controls.Add(tbxLibelle);
            tabEnregistrerConference.Controls.Add(lblLibelle);
            tabEnregistrerConference.Controls.Add(lblTitre);
            tabEnregistrerConference.Controls.Add(lblChoixHackaton);
            tabEnregistrerConference.Controls.Add(cbxChoixDeHackaton);
            tabEnregistrerConference.Location = new Point(4, 24);
            tabEnregistrerConference.Name = "tabEnregistrerConference";
            tabEnregistrerConference.Padding = new Padding(3);
            tabEnregistrerConference.Size = new Size(457, 380);
            tabEnregistrerConference.TabIndex = 0;
            tabEnregistrerConference.Text = "Enregistrer";
            tabEnregistrerConference.UseVisualStyleBackColor = true;
            // 
            // cbxIntervenant
            // 
            cbxIntervenant.FormattingEnabled = true;
            cbxIntervenant.Location = new Point(145, 283);
            cbxIntervenant.Name = "cbxIntervenant";
            cbxIntervenant.Size = new Size(287, 23);
            cbxIntervenant.TabIndex = 42;
            // 
            // lblIntervenant
            // 
            lblIntervenant.AutoSize = true;
            lblIntervenant.Location = new Point(66, 286);
            lblIntervenant.Name = "lblIntervenant";
            lblIntervenant.Size = new Size(73, 15);
            lblIntervenant.TabIndex = 41;
            lblIntervenant.Text = "Intervenant :";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(370, 351);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 40;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(204, 184);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(28, 15);
            lblMinute.TabIndex = 39;
            lblMinute.Text = "min";
            // 
            // numDuree
            // 
            numDuree.Location = new Point(145, 182);
            numDuree.Name = "numDuree";
            numDuree.Size = new Size(53, 23);
            numDuree.TabIndex = 38;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(288, 351);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(76, 23);
            btnEnregistrer.TabIndex = 37;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // tbxTheme
            // 
            tbxTheme.Location = new Point(144, 246);
            tbxTheme.Name = "tbxTheme";
            tbxTheme.Size = new Size(258, 23);
            tbxTheme.TabIndex = 36;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(89, 249);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(49, 15);
            lblTheme.TabIndex = 35;
            lblTheme.Text = "Theme :";
            // 
            // tbxSalle
            // 
            tbxSalle.Location = new Point(144, 213);
            tbxSalle.Name = "tbxSalle";
            tbxSalle.Size = new Size(100, 23);
            tbxSalle.TabIndex = 34;
            // 
            // lblSalle
            // 
            lblSalle.AutoSize = true;
            lblSalle.Location = new Point(101, 216);
            lblSalle.Name = "lblSalle";
            lblSalle.Size = new Size(37, 15);
            lblSalle.TabIndex = 33;
            lblSalle.Text = "Salle :";
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(340, 144);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(69, 23);
            dtpTime.TabIndex = 32;
            dtpTime.Value = new DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(219, 190);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(0, 15);
            lblMin.TabIndex = 31;
            // 
            // lblDuree
            // 
            lblDuree.AutoSize = true;
            lblDuree.Location = new Point(11, 184);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(128, 15);
            lblDuree.TabIndex = 30;
            lblDuree.Text = "Durée de l'evenement :";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(144, 144);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(190, 23);
            dtpDate.TabIndex = 29;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(103, 152);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(36, 15);
            lblDate.TabIndex = 28;
            lblDate.Text = "date :";
            // 
            // tbxLibelle
            // 
            tbxLibelle.Location = new Point(144, 106);
            tbxLibelle.Name = "tbxLibelle";
            tbxLibelle.Size = new Size(243, 23);
            tbxLibelle.TabIndex = 27;
            // 
            // lblLibelle
            // 
            lblLibelle.AutoSize = true;
            lblLibelle.Location = new Point(92, 109);
            lblLibelle.Name = "lblLibelle";
            lblLibelle.Size = new Size(47, 15);
            lblLibelle.TabIndex = 26;
            lblLibelle.Text = "Libelle :";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitre.Location = new Point(11, 12);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(336, 37);
            lblTitre.TabIndex = 25;
            lblTitre.Text = "Enregistrer une Conférence";
            // 
            // lblChoixHackaton
            // 
            lblChoixHackaton.AutoSize = true;
            lblChoixHackaton.Location = new Point(11, 71);
            lblChoixHackaton.Name = "lblChoixHackaton";
            lblChoixHackaton.Size = new Size(125, 30);
            lblChoixHackaton.TabIndex = 24;
            lblChoixHackaton.Text = "Choisissez le hackaton\r\nde cette conférence";
            // 
            // cbxChoixDeHackaton
            // 
            cbxChoixDeHackaton.FormattingEnabled = true;
            cbxChoixDeHackaton.Location = new Point(142, 68);
            cbxChoixDeHackaton.Name = "cbxChoixDeHackaton";
            cbxChoixDeHackaton.Size = new Size(290, 23);
            cbxChoixDeHackaton.TabIndex = 23;
            // 
            // tabRappelConference
            // 
            tabRappelConference.Controls.Add(btnMail);
            tabRappelConference.Controls.Add(cbxListeConferences);
            tabRappelConference.Controls.Add(labelRappelConf);
            tabRappelConference.Location = new Point(4, 24);
            tabRappelConference.Name = "tabRappelConference";
            tabRappelConference.Padding = new Padding(3);
            tabRappelConference.Size = new Size(457, 380);
            tabRappelConference.TabIndex = 1;
            tabRappelConference.Text = "Rappels";
            tabRappelConference.UseVisualStyleBackColor = true;
            // 
            // btnMail
            // 
            btnMail.Location = new Point(27, 330);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(184, 34);
            btnMail.TabIndex = 28;
            btnMail.Text = "Envoyer un mail de rapport";
            btnMail.UseVisualStyleBackColor = true;
            btnMail.Click += btnMail_Click;
            // 
            // cbxListeConferences
            // 
            cbxListeConferences.FormattingEnabled = true;
            cbxListeConferences.Location = new Point(164, 15);
            cbxListeConferences.Name = "cbxListeConferences";
            cbxListeConferences.Size = new Size(277, 23);
            cbxListeConferences.TabIndex = 27;
            cbxListeConferences.SelectedIndexChanged += cbxListeConferences_SelectedIndexChanged;
            // 
            // labelRappelConf
            // 
            labelRappelConf.AutoSize = true;
            labelRappelConf.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelRappelConf.Location = new Point(6, 18);
            labelRappelConf.Name = "labelRappelConf";
            labelRappelConf.Size = new Size(152, 15);
            labelRappelConf.TabIndex = 26;
            labelRappelConf.Text = "Choisissez une conférence :";
            // 
            // enregistrerConference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 426);
            Controls.Add(tabConferences);
            Controls.Add(lblMessage);
            Name = "enregistrerConference";
            Text = "enregistrer";
            Load += enregistrerConference_Load;
            tabConferences.ResumeLayout(false);
            tabEnregistrerConference.ResumeLayout(false);
            tabEnregistrerConference.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuree).EndInit();
            tabRappelConference.ResumeLayout(false);
            tabRappelConference.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMessage;
        private TabControl tabConferences;
        private TabPage tabEnregistrerConference;
        private ComboBox cbxIntervenant;
        private Label lblIntervenant;
        private Button btnRetour;
        private Label lblMinute;
        private NumericUpDown numDuree;
        private Button btnEnregistrer;
        private TextBox tbxTheme;
        private Label lblTheme;
        private TextBox tbxSalle;
        private Label lblSalle;
        private DateTimePicker dtpTime;
        private Label lblMin;
        private Label lblDuree;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private TextBox tbxLibelle;
        private Label lblLibelle;
        private Label lblTitre;
        private Label lblChoixHackaton;
        private ComboBox cbxChoixDeHackaton;
        private TabPage tabRappelConference;
        private ComboBox cbxListeConferences;
        private Label labelRappelConf;
        private Button btnMail;
    }
}