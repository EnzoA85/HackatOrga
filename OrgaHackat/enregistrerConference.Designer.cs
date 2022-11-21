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
            this.cbxChoixDeHackaton = new System.Windows.Forms.ComboBox();
            this.lblChoixHackaton = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.tbxLibelle = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblSalle = new System.Windows.Forms.Label();
            this.tbxSalle = new System.Windows.Forms.TextBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.tbxTheme = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.numDuree = new System.Windows.Forms.NumericUpDown();
            this.lblMinute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuree)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxChoixDeHackaton
            // 
            this.cbxChoixDeHackaton.FormattingEnabled = true;
            this.cbxChoixDeHackaton.Location = new System.Drawing.Point(143, 74);
            this.cbxChoixDeHackaton.Name = "cbxChoixDeHackaton";
            this.cbxChoixDeHackaton.Size = new System.Drawing.Size(290, 23);
            this.cbxChoixDeHackaton.TabIndex = 0;
            this.cbxChoixDeHackaton.SelectedIndexChanged += new System.EventHandler(this.cbxChoixDeHackaton_SelectedIndexChanged);
            // 
            // lblChoixHackaton
            // 
            this.lblChoixHackaton.AutoSize = true;
            this.lblChoixHackaton.Location = new System.Drawing.Point(12, 77);
            this.lblChoixHackaton.Name = "lblChoixHackaton";
            this.lblChoixHackaton.Size = new System.Drawing.Size(125, 30);
            this.lblChoixHackaton.TabIndex = 1;
            this.lblChoixHackaton.Text = "Choisissez le hackaton\r\nde cette conférence";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(12, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(336, 37);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Enregistrer une Conférence";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(93, 115);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(47, 15);
            this.lblLibelle.TabIndex = 3;
            this.lblLibelle.Text = "Libelle :";
            // 
            // tbxLibelle
            // 
            this.tbxLibelle.Location = new System.Drawing.Point(145, 112);
            this.tbxLibelle.Name = "tbxLibelle";
            this.tbxLibelle.Size = new System.Drawing.Size(243, 23);
            this.tbxLibelle.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(104, 158);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 15);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "date :";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(145, 150);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 23);
            this.dtpDate.TabIndex = 6;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(12, 190);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(128, 15);
            this.lblDuree.TabIndex = 7;
            this.lblDuree.Text = "Durée de l\'evenement :";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(220, 196);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 15);
            this.lblMin.TabIndex = 9;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(341, 150);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(69, 23);
            this.dtpTime.TabIndex = 10;
            this.dtpTime.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Location = new System.Drawing.Point(102, 222);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(37, 15);
            this.lblSalle.TabIndex = 11;
            this.lblSalle.Text = "Salle :";
            // 
            // tbxSalle
            // 
            this.tbxSalle.Location = new System.Drawing.Point(145, 219);
            this.tbxSalle.Name = "tbxSalle";
            this.tbxSalle.Size = new System.Drawing.Size(100, 23);
            this.tbxSalle.TabIndex = 13;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(90, 255);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(49, 15);
            this.lblTheme.TabIndex = 14;
            this.lblTheme.Text = "Theme :";
            // 
            // tbxTheme
            // 
            this.tbxTheme.Location = new System.Drawing.Point(145, 252);
            this.tbxTheme.Name = "tbxTheme";
            this.tbxTheme.Size = new System.Drawing.Size(258, 23);
            this.tbxTheme.TabIndex = 15;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(357, 305);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(76, 23);
            this.btnEnregistrer.TabIndex = 16;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // numDuree
            // 
            this.numDuree.Location = new System.Drawing.Point(146, 188);
            this.numDuree.Name = "numDuree";
            this.numDuree.Size = new System.Drawing.Size(53, 23);
            this.numDuree.TabIndex = 17;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(205, 190);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(28, 15);
            this.lblMinute.TabIndex = 18;
            this.lblMinute.Text = "min";
            // 
            // enregistrerConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 340);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.numDuree);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.tbxTheme);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.tbxSalle);
            this.Controls.Add(this.lblSalle);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbxLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblChoixHackaton);
            this.Controls.Add(this.cbxChoixDeHackaton);
            this.Name = "enregistrerConference";
            this.Text = "enregistrer";
            this.Load += new System.EventHandler(this.enregistrerConference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDuree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxChoixDeHackaton;
        private Label lblChoixHackaton;
        private Label lblTitre;
        private Label lblLibelle;
        private TextBox tbxLibelle;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblDuree;
        private Label lblMin;
        private DateTimePicker dtpTime;
        private Label lblSalle;
        private TextBox tbxSalle;
        private Label lblTheme;
        private TextBox tbxTheme;
        private Button btnEnregistrer;
        private NumericUpDown numDuree;
        private Label lblMinute;
    }
}