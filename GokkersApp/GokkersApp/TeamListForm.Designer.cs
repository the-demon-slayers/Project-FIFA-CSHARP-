namespace GokkersApp
{
    partial class TeamListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.newTeamButton = new System.Windows.Forms.Button();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "     Teams";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(4, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 242);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // newTeamButton
            // 
            this.newTeamButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newTeamButton.Location = new System.Drawing.Point(4, 296);
            this.newTeamButton.Name = "newTeamButton";
            this.newTeamButton.Size = new System.Drawing.Size(382, 23);
            this.newTeamButton.TabIndex = 9;
            this.newTeamButton.Text = "Nieuwe Team Toevoegen";
            this.newTeamButton.UseVisualStyleBackColor = true;
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTeamButton.Location = new System.Drawing.Point(4, 354);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(382, 23);
            this.deleteTeamButton.TabIndex = 10;
            this.deleteTeamButton.Text = "Verwijder Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerButton.Location = new System.Drawing.Point(4, 325);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(382, 23);
            this.addPlayerButton.TabIndex = 11;
            this.addPlayerButton.Text = "Nieuwe Player Maken";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePlayerButton.Location = new System.Drawing.Point(4, 383);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(382, 23);
            this.deletePlayerButton.TabIndex = 12;
            this.deletePlayerButton.Text = "Verwijder Player";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // TeamListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 420);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.newTeamButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "TeamListForm";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.TeamListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button newTeamButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button deletePlayerButton;
    }
}