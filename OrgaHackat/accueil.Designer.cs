namespace OrgaHackat
{
    partial class accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hackathons = new System.Windows.Forms.Button();
            this.btninitiation = new System.Windows.Forms.Button();
            this.btn_conference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "HackatAgence";
            // 
            // btn_hackathons
            // 
            this.btn_hackathons.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hackathons.Location = new System.Drawing.Point(52, 308);
            this.btn_hackathons.Name = "btn_hackathons";
            this.btn_hackathons.Size = new System.Drawing.Size(213, 74);
            this.btn_hackathons.TabIndex = 1;
            this.btn_hackathons.Text = "Hackathons";
            this.btn_hackathons.UseVisualStyleBackColor = true;
            // 
            // btninitiation
            // 
            this.btninitiation.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninitiation.Location = new System.Drawing.Point(290, 308);
            this.btninitiation.Name = "btninitiation";
            this.btninitiation.Size = new System.Drawing.Size(213, 74);
            this.btninitiation.TabIndex = 2;
            this.btninitiation.Text = "Initiation";
            this.btninitiation.UseVisualStyleBackColor = true;
            this.btninitiation.Click += new System.EventHandler(this.btninitiation_Click);
            // 
            // btn_conference
            // 
            this.btn_conference.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_conference.Location = new System.Drawing.Point(519, 308);
            this.btn_conference.Name = "btn_conference";
            this.btn_conference.Size = new System.Drawing.Size(216, 74);
            this.btn_conference.TabIndex = 3;
            this.btn_conference.Text = "Conférences";
            this.btn_conference.UseVisualStyleBackColor = true;
            this.btn_conference.Click += new System.EventHandler(this.btn_conference_Click);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_conference);
            this.Controls.Add(this.btninitiation);
            this.Controls.Add(this.btn_hackathons);
            this.Controls.Add(this.label1);
            this.Name = "accueil";
            this.Text = "la";
            this.Load += new System.EventHandler(this.accueil_Load);
            this.Text = "HackatAgence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_hackathons;
        private Button btninitiation;
        private Button btn_conference;
    }
}