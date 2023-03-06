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
            label1 = new Label();
            btn_hackathons = new Button();
            btninitiation = new Button();
            btn_conference = new Button();
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
            btn_hackathons.Location = new Point(52, 308);
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
            btninitiation.Location = new Point(290, 308);
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
            btn_conference.Location = new Point(519, 308);
            btn_conference.Name = "btn_conference";
            btn_conference.Size = new Size(216, 74);
            btn_conference.TabIndex = 3;
            btn_conference.Text = "Conférences";
            btn_conference.UseVisualStyleBackColor = true;
            btn_conference.Click += btn_conference_Click;
            // 
            // accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_conference);
            Controls.Add(btninitiation);
            Controls.Add(btn_hackathons);
            Controls.Add(label1);
            Name = "accueil";
            Text = "HackatAgence";
            Load += accueil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_hackathons;
        private Button btninitiation;
        private Button btn_conference;
    }
}