using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voxel_Text_Editor
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();

            returnSettings();
        }

        public void returnSettings()
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(38, 38, 38);    //dark theme
                hlibLabel.ForeColor = Color.White;
                dateLabel.ForeColor = Color.DarkGray;
                versionLabel.ForeColor = Color.DarkGray;

            }
            else if (Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = Color.White;   //light theme
                hlibLabel.ForeColor = Color.Black;
                dateLabel.ForeColor = Color.LightGray;
                versionLabel.ForeColor = Color.LightGray;
            }
            else
            {
                this.BackColor = ControlPaint.Dark(Properties.Settings.Default.ThemeColor, 0.6f);   //cutsom theme
                hlibLabel.ForeColor = ControlPaint.Light(Properties.Settings.Default.ThemeColor, 0.6f);
                dateLabel.ForeColor = ControlPaint.Light(Properties.Settings.Default.ThemeColor, 0.1f);
                versionLabel.ForeColor = ControlPaint.Light(Properties.Settings.Default.ThemeColor, 0.1f);
            }
        }
    }
}
