using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Voxel_Text_Editor
{
    public partial class Settings : Form
    {
        public static Settings instance;
        public Settings()
        {
            InitializeComponent();
            instance = this;

            //return Settings
            returnSettings();
        }

        private void showTBarCH(object sender, EventArgs e)
        {
            if(showToolbarCheck.Checked) 
            {
                Properties.Settings.Default.ShowBar = true;
            }
            else
            {
                MessageBox.Show("You have disabled 'Toolbar' so use CTRL + B to open settings", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Properties.Settings.Default.ShowBar = false;
            }

            returnSettings();
        }

        private void themeComboCH(object sender, EventArgs e)
        {
            if(comboTheme.Text == "Light")
            {
                Properties.Settings.Default.Theme = "light";
            }
            else if(comboTheme.Text == "Dark")
            {
                Properties.Settings.Default.Theme = "dark";
            }

            returnSettings();
        }

        private void tranpanCH(object sender, EventArgs e)
        {
            tranLabel.Text = "Window Opacity: " + tranpanBar.Value.ToString() + "%";
            Properties.Settings.Default.WinOpacity = tranpanBar.Value;

            returnSettings();
        }

        private void showAboveCH(object sender, EventArgs e)
        {
            if(showAboveCheck.Checked)
            {
                Properties.Settings.Default.ShowAbove= true;
            }
            else
            {
                Properties.Settings.Default.ShowAbove = false;
            }

            returnSettings();
        }

        public void returnSettings()
        {
            TextEditor.instance.returnSettings();
            showToolbarCheck.Checked = Properties.Settings.Default.ShowBar;
            tranpanBar.Value = Properties.Settings.Default.WinOpacity;
            showAboveCheck.Checked = Properties.Settings.Default.ShowAbove;

            if (Properties.Settings.Default.Theme == "dark")
            {
                this.BackColor = Color.FromArgb(38, 38, 38); //dark theme
                showToolbarCheck.ForeColor = Color.White;
                showAboveCheck.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                tranLabel.ForeColor = Color.White;
                fontLabel.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;               //light theme
                showToolbarCheck.ForeColor = Color.Black;
                showAboveCheck.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                tranLabel.ForeColor = Color.Black;
                fontLabel.ForeColor = Color.Black;
            }
        }

        private void fontComboCH(object sender, EventArgs e)
        {
            
        }
    }
}
