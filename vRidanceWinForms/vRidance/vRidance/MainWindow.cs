using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Microsoft.Win32;
using System.Windows;

namespace vRidance
{
    public partial class grdMain : Form
    {
        Label[] arrAllLabels;
        //light Theme Colors
        Color LightThemeForm = SystemColors.ControlLightLight;
        Color LightThemeButtonBG = Color.MediumSlateBlue;
        Color LightThemeButtonBGDisabled = Color.DarkSlateBlue;
        Color LightThemeFontColor = Color.Black;

        //Dark Theme Colors
        Color DarkThemeForm = Color.FromArgb(33, 33, 33);
        Color DarkThemeButtonBG = Color.MediumSlateBlue;
        Color DarkThemeButtonBGDisabled = Color.DarkSlateBlue;
        Color DarkThemeFontColor = Color.White;

        List<String> itemList = new List<String>();
        public grdMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkbxTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxTheme.Checked)
            {
                this.BackColor = DarkThemeForm;
                //lstItems.BackColor = DarkThemeForm;


                btnUpload.BackColor = DarkThemeButtonBG;

                if (btnNext.Enabled == true) btnNext.BackColor = DarkThemeButtonBG;
                else btnNext.BackColor = DarkThemeButtonBGDisabled;

                lblDarkTheme.ForeColor = DarkThemeFontColor;
                if (arrAllLabels != null)
                {
                    foreach (Label item in arrAllLabels)
                    {
                        item.ForeColor = DarkThemeFontColor;
                    }
                }
                
            }
            else
            {
                this.BackColor = LightThemeForm;
                //lstItems.BackColor = LightThemeForm;

                btnUpload.BackColor = LightThemeButtonBG;

                if (btnNext.Enabled == true) btnNext.BackColor = LightThemeButtonBG;
                else btnNext.BackColor = LightThemeButtonBGDisabled;

                lblDarkTheme.ForeColor = LightThemeFontColor;

                if (arrAllLabels != null)
                {
                    foreach (Label item in arrAllLabels)
                    {
                        item.ForeColor = LightThemeFontColor;
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select vSphere Files";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sFileName = openFileDialog.FileName;
                    string[] arrAllFiles = openFileDialog.FileNames;
                    int i = 0;
                    int nextLbl = 50;
                    int labelHeight = 25;
                    arrAllLabels = new Label[arrAllFiles.Length];
                    foreach (string file in arrAllFiles)
                    {
                        string nameoffile = Path.GetFileName(file);
                        arrAllLabels[i] = new Label();
                        arrAllLabels[i].Name = "lblFile" + i;
                        arrAllLabels[i].Size = new System.Drawing.Size(816, labelHeight);
                        arrAllLabels[i].Location = new System.Drawing.Point(0, nextLbl);
                        arrAllLabels[i].Margin = new System.Windows.Forms.Padding(10, 0, 10 , 0);
                        arrAllLabels[i].Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        arrAllLabels[i].Text = nameoffile;
                        arrAllLabels[i].TabIndex = 8;
                        if (chkbxTheme.Checked) arrAllLabels[i].ForeColor = DarkThemeFontColor;
                        else arrAllLabels[i].ForeColor = LightThemeFontColor;
                        arrAllLabels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.Controls.Add(arrAllLabels[i]);

                        i++;
                        nextLbl += labelHeight;
                    }
                    btnNext.Enabled = true;
                    if (chkbxTheme.Checked) btnNext.BackColor = DarkThemeButtonBG;
                    else btnNext.BackColor = LightThemeButtonBG;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MigrateSelection migratepage = new MigrateSelection();
            this.IsMdiContainer = true;
            migratepage.MdiParent = this;
            migratepage.Show();
        }
    }
}
