using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voxel_Text_Editor
{
    public partial class TextEditor : Form
    {
        public static TextEditor instance;

        public MenuStrip ms1;
        public TextBox txb1;

        public string filePath = "null";
        public bool saved = true;
        public byte fontSize = 14;

        public TextEditor()
        {
            InitializeComponent();
            instance = this;

            //Setting Instances
            ms1 = menuStrip1;
            txb1 = textmBox;

            //Returning Settings
            returnSettings();
        }

        private void openFileStrip(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "txt files|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textmBox.Text = File.ReadAllText(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
                saved = true;
                isSaved();
            }
        }

        private void saveAsFileStrip(object sender, EventArgs e)
        {
            saveAsFile();
        }

        private void saveFileStrip(object sender, EventArgs e)
        {
            if (filePath == "null")
            {
                saveAsFile();
            }
            else
            {
                File.WriteAllText(filePath, textmBox.Text);
                this.Name = "Voxel Editor";
                saved = true;
                isSaved();
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            saved = false;
            isSaved();
        }

        private void InfoStrip(object sender, EventArgs e)
        {
            Information info = new Information();
            info.ShowDialog();
        }

        private void settingsStrip(object sender, EventArgs e)
        {
            Settings stc = new Settings();
            stc.ShowDialog();
        }

        public void returnSettings() //Dark, light theme properties 
        {
            menuStrip1.Visible = Properties.Settings.Default.ShowBar;
            this.TopMost = Properties.Settings.Default.ShowAbove;
            this.Opacity = ((double)(Properties.Settings.Default.WinOpacity) / 100.0);

            if(Properties.Settings.Default.Theme == "dark") //Dark Theme
            {
                textmBox.BackColor = Color.FromArgb(38, 38, 38);
                textmBox.ForeColor = Color.White;
                menuStrip1.BackColor = Color.FromArgb(89, 89, 89);
                fileStrip.ForeColor = Color.White;
                editorStrip.ForeColor = Color.White;
                formatStrip.ForeColor = Color.White;
                viewStrip.ForeColor = Color.White;

            }
            else
            {
                textmBox.BackColor = Color.LightGray; //Light Theme
                textmBox.ForeColor = Color.Black;
                menuStrip1.BackColor = Color.White;
                fileStrip.ForeColor = Color.Black;
                editorStrip.ForeColor = Color.Black;
                formatStrip.ForeColor = Color.Black;
                viewStrip.ForeColor = Color.Black;
            }

            Properties.Settings.Default.Save();
        }

        public void isSaved()
        {
            if(saved)
            {
                this.Text = "Voxel Text Editor";
            }
            else
            {
                this.Text = String.Format("*{0}", filePath);
            }
        }

        public void saveAsFile()
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Txt files|*.txt|All files|*.*";

            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textmBox.Text);
                saved = true;
                filePath = saveFileDialog1.FileName;
                isSaved();
            }
        }
        private void textEditorClosing(object sender, FormClosingEventArgs e)
        {
            if(!saved)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes to " + filePath, "Voxel Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    saveAsFile();
                }
                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void zoomOut(object sender, EventArgs e)
        {
            textmBox.Font = new Font(textmBox.Font.Name, fontSize);

            if (fontSize > 5)
            {
                fontSize -= 1;
            }
        }

        private void zoomIn(object sender, EventArgs e)
        {
            textmBox.Font = new Font(textmBox.Font.Name, fontSize);
            if (fontSize < 100)
            {
                fontSize += 1;
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            Settings stc = new Settings();
            stc.ShowDialog();
        }
    }
}
