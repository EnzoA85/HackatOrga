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
            this.editHackathon = new System.Windows.Forms.TabPage();
            this.tbc_hackathons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_hackathons
            // 
            this.tbc_hackathons.Controls.Add(this.ajouterHackathon);
            this.tbc_hackathons.Controls.Add(this.editHackathon);
            this.tbc_hackathons.Location = new System.Drawing.Point(12, 12);
            this.tbc_hackathons.Name = "tbc_hackathons";
            this.tbc_hackathons.SelectedIndex = 0;
            this.tbc_hackathons.Size = new System.Drawing.Size(776, 426);
            this.tbc_hackathons.TabIndex = 0;
            // 
            // ajouterHackathon
            // 
            this.ajouterHackathon.Location = new System.Drawing.Point(4, 24);
            this.ajouterHackathon.Name = "ajouterHackathon";
            this.ajouterHackathon.Padding = new System.Windows.Forms.Padding(3);
            this.ajouterHackathon.Size = new System.Drawing.Size(768, 398);
            this.ajouterHackathon.TabIndex = 0;
            this.ajouterHackathon.Text = "Ajouter";
            this.ajouterHackathon.UseVisualStyleBackColor = true;
            // 
            // editHackathon
            // 
            this.editHackathon.Location = new System.Drawing.Point(4, 24);
            this.editHackathon.Name = "editHackathon";
            this.editHackathon.Padding = new System.Windows.Forms.Padding(3);
            this.editHackathon.Size = new System.Drawing.Size(768, 398);
            this.editHackathon.TabIndex = 1;
            this.editHackathon.Text = "Modifier";
            this.editHackathon.UseVisualStyleBackColor = true;
            this.editHackathon.Click += new System.EventHandler(this.editHackathon_Click);
            // 
            // hackathons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_hackathons);
            this.Name = "hackathons";
            this.Text = "hackathons";
            this.tbc_hackathons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbc_hackathons;
        private TabPage ajouterHackathon;
        private TabPage editHackathon;
    }
}