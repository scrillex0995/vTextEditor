namespace Voxel_Text_Editor
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.hlibLabel = new System.Windows.Forms.Label();
            this.iconPic = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.titelLabel = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // hlibLabel
            // 
            this.hlibLabel.AutoSize = true;
            this.hlibLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlibLabel.Location = new System.Drawing.Point(139, 58);
            this.hlibLabel.Name = "hlibLabel";
            this.hlibLabel.Size = new System.Drawing.Size(169, 20);
            this.hlibLabel.TabIndex = 1;
            this.hlibLabel.Text = "created by scrillex0995";
            // 
            // iconPic
            // 
            this.iconPic.Image = global::Voxel_Text_Editor.Properties.Resources.VoxelEditorICO;
            this.iconPic.Location = new System.Drawing.Point(12, 12);
            this.iconPic.Name = "iconPic";
            this.iconPic.Size = new System.Drawing.Size(100, 100);
            this.iconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPic.TabIndex = 2;
            this.iconPic.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateLabel.Location = new System.Drawing.Point(151, 92);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(157, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "build date: 10/7/2023";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.versionLabel.Location = new System.Drawing.Point(216, 120);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(89, 20);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Version 5.0";
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.Location = new System.Drawing.Point(118, 12);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(196, 29);
            this.titelLabel.TabIndex = 5;
            this.titelLabel.Text = "Voxel Text Editor";
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLink.Location = new System.Drawing.Point(12, 121);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(47, 18);
            this.githubLink.TabIndex = 6;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "github";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubClicked);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 149);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.iconPic);
            this.Controls.Add(this.hlibLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Information";
            this.Text = "Info                                 ";
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hlibLabel;
        private System.Windows.Forms.PictureBox iconPic;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}