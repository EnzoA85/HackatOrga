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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accueil));
            label1 = new Label();
            btn_hackathons = new Button();
            btninitiation = new Button();
            btn_conference = new Button();
            pictureBox1 = new PictureBox();
            btn_statistique = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(252, 23);
            label1.Name = "label1";
            label1.Size = new Size(268, 47);
            label1.TabIndex = 0;
            label1.Text = "HackatAgence";
            // 
            // btn_hackathons
            // 
            btn_hackathons.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hackathons.Location = new Point(575, 100);
            btn_hackathons.Name = "btn_hackathons";
            btn_hackathons.Size = new Size(213, 74);
            btn_hackathons.TabIndex = 1;
            btn_hackathons.Text = "Hackathons";
            btn_hackathons.UseVisualStyleBackColor = true;
            btn_hackathons.Click += btn_hackathons_Click;
            // 
            // btninitiation
            // 
            btninitiation.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            btninitiation.Location = new Point(575, 180);
            btninitiation.Name = "btninitiation";
            btninitiation.Size = new Size(213, 74);
            btninitiation.TabIndex = 2;
            btninitiation.Text = "Initiation";
            btninitiation.UseVisualStyleBackColor = true;
            btninitiation.Click += btninitiation_Click;
            // 
            // btn_conference
            // 
            btn_conference.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_conference.Location = new Point(575, 260);
            btn_conference.Name = "btn_conference";
            btn_conference.Size = new Size(216, 74);
            btn_conference.TabIndex = 3;
            btn_conference.Text = "Conférences";
            btn_conference.UseVisualStyleBackColor = true;
            btn_conference.Click += btn_conference_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_statistique
            // 
            btn_statistique.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_statistique.Location = new Point(575, 340);
            btn_statistique.Name = "btn_statistique";
            btn_statistique.Size = new Size(216, 74);
            btn_statistique.TabIndex = 5;
            btn_statistique.Text = "Statistiques";
            btn_statistique.UseVisualStyleBackColor = true;
            btn_statistique.Click += btn_statistique_Click;
            // 
            // accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_statistique);
            Controls.Add(pictureBox1);
            Controls.Add(btn_conference);
            Controls.Add(btninitiation);
            Controls.Add(btn_hackathons);
            Controls.Add(label1);
            Name = "accueil";
            Text = "HackatAgence";
            Load += accueil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_hackathons;
        private Button btninitiation;
        private Button btn_conference;
        private PictureBox pictureBox1;
        private Button btn_statistique;
    }
}