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
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // hlibLabel
            // 
            this.hlibLabel.AutoSize = true;
            this.hlibLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlibLabel.Location = new System.Drawing.Point(125, 48);
            this.hlibLabel.Name = "hlibLabel";
            this.hlibLabel.Size = new System.Drawing.Size(141, 26);
            this.hlibLabel.TabIndex = 1;
            this.hlibLabel.Text = "created by Hlib";
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
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateLabel.Location = new System.Drawing.Point(118, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(150, 19);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "build date: 06/1/2023";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.versionLabel.Location = new System.Drawing.Point(146, 93);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(81, 19);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Version 4.0";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 124);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.iconPic);
            this.Controls.Add(this.hlibLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Information";
            this.Text = "                                      ";
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hlibLabel;
        private System.Windows.Forms.PictureBox iconPic;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}