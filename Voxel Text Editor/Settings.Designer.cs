namespace Voxel_Text_Editor
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.showToolbarCheck = new System.Windows.Forms.CheckBox();
            this.comboTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tranpanBar = new System.Windows.Forms.TrackBar();
            this.tranLabel = new System.Windows.Forms.Label();
            this.showAboveCheck = new System.Windows.Forms.CheckBox();
            this.fontLabel = new System.Windows.Forms.Label();
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tranpanBar)).BeginInit();
            this.SuspendLayout();
            // 
            // showToolbarCheck
            // 
            this.showToolbarCheck.AutoSize = true;
            this.showToolbarCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showToolbarCheck.Location = new System.Drawing.Point(12, 12);
            this.showToolbarCheck.Name = "showToolbarCheck";
            this.showToolbarCheck.Size = new System.Drawing.Size(120, 22);
            this.showToolbarCheck.TabIndex = 0;
            this.showToolbarCheck.Text = "Show Toolbar";
            this.showToolbarCheck.UseVisualStyleBackColor = true;
            this.showToolbarCheck.CheckedChanged += new System.EventHandler(this.showTBarCH);
            // 
            // comboTheme
            // 
            this.comboTheme.BackColor = System.Drawing.SystemColors.Window;
            this.comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTheme.FormattingEnabled = true;
            this.comboTheme.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "Custom"});
            this.comboTheme.Location = new System.Drawing.Point(12, 82);
            this.comboTheme.Name = "comboTheme";
            this.comboTheme.Size = new System.Drawing.Size(121, 21);
            this.comboTheme.TabIndex = 2;
            this.comboTheme.SelectedIndexChanged += new System.EventHandler(this.themeComboCH);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Theme";
            // 
            // tranpanBar
            // 
            this.tranpanBar.Location = new System.Drawing.Point(11, 185);
            this.tranpanBar.Maximum = 100;
            this.tranpanBar.Minimum = 25;
            this.tranpanBar.Name = "tranpanBar";
            this.tranpanBar.Size = new System.Drawing.Size(177, 45);
            this.tranpanBar.TabIndex = 5;
            this.tranpanBar.TickFrequency = 0;
            this.tranpanBar.Value = 100;
            this.tranpanBar.ValueChanged += new System.EventHandler(this.tranpanCH);
            // 
            // tranLabel
            // 
            this.tranLabel.AutoSize = true;
            this.tranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranLabel.Location = new System.Drawing.Point(12, 166);
            this.tranLabel.Name = "tranLabel";
            this.tranLabel.Size = new System.Drawing.Size(143, 16);
            this.tranLabel.TabIndex = 6;
            this.tranLabel.Text = "Window Opacity: 100%";
            // 
            // showAboveCheck
            // 
            this.showAboveCheck.AutoSize = true;
            this.showAboveCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAboveCheck.Location = new System.Drawing.Point(12, 40);
            this.showAboveCheck.Name = "showAboveCheck";
            this.showAboveCheck.Size = new System.Drawing.Size(217, 22);
            this.showAboveCheck.TabIndex = 7;
            this.showAboveCheck.Text = "Show Above Other Windows";
            this.showAboveCheck.UseVisualStyleBackColor = true;
            this.showAboveCheck.CheckedChanged += new System.EventHandler(this.showAboveCH);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontLabel.Location = new System.Drawing.Point(138, 122);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(33, 16);
            this.fontLabel.TabIndex = 9;
            this.fontLabel.Text = "Font";
            // 
            // comboFont
            // 
            this.comboFont.BackColor = System.Drawing.SystemColors.Window;
            this.comboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFont.FormattingEnabled = true;
            this.comboFont.Location = new System.Drawing.Point(11, 119);
            this.comboFont.Name = "comboFont";
            this.comboFont.Size = new System.Drawing.Size(121, 21);
            this.comboFont.TabIndex = 8;
            this.comboFont.SelectedIndexChanged += new System.EventHandler(this.fontComboCH);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Khaki;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 242);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.comboFont);
            this.Controls.Add(this.showAboveCheck);
            this.Controls.Add(this.tranLabel);
            this.Controls.Add(this.tranpanBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTheme);
            this.Controls.Add(this.showToolbarCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.tranpanBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showToolbarCheck;
        private System.Windows.Forms.ComboBox comboTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tranpanBar;
        private System.Windows.Forms.Label tranLabel;
        private System.Windows.Forms.CheckBox showAboveCheck;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.ComboBox comboFont;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}