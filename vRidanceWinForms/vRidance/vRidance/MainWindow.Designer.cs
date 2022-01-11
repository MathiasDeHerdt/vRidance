namespace vRidance
{
    partial class grdMain
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
            this.lblDarkTheme = new System.Windows.Forms.Label();
            this.btnNext = new vRidance.CustomControls.CustomButton();
            this.btnUpload = new vRidance.CustomControls.CustomButton();
            this.chkbxTheme = new vRidance.CustomControls.CustomToggle();
            this.SuspendLayout();
            // 
            // lblDarkTheme
            // 
            this.lblDarkTheme.AutoSize = true;
            this.lblDarkTheme.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDarkTheme.Location = new System.Drawing.Point(660, 16);
            this.lblDarkTheme.Name = "lblDarkTheme";
            this.lblDarkTheme.Size = new System.Drawing.Size(77, 15);
            this.lblDarkTheme.TabIndex = 1;
            this.lblDarkTheme.Text = "Dark Theme";
            this.lblDarkTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNext.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNext.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNext.BorderRadius = 13;
            this.btnNext.BorderSize = 0;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(400, 400);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "NEXT";
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpload.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpload.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpload.BorderRadius = 13;
            this.btnUpload.BorderSize = 0;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(248, 400);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 40);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.TextColor = System.Drawing.Color.White;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // chkbxTheme
            // 
            this.chkbxTheme.AutoSize = true;
            this.chkbxTheme.Location = new System.Drawing.Point(743, 12);
            this.chkbxTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.chkbxTheme.Name = "chkbxTheme";
            this.chkbxTheme.OffBackColor = System.Drawing.Color.Gray;
            this.chkbxTheme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.chkbxTheme.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.chkbxTheme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.chkbxTheme.Size = new System.Drawing.Size(45, 22);
            this.chkbxTheme.TabIndex = 0;
            this.chkbxTheme.UseVisualStyleBackColor = true;
            this.chkbxTheme.CheckedChanged += new System.EventHandler(this.chkbxTheme_CheckedChanged);
            // 
            // grdMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblDarkTheme);
            this.Controls.Add(this.chkbxTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "grdMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vRidance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomToggle chkbxTheme;
        private System.Windows.Forms.Label lblDarkTheme;
        private CustomControls.CustomButton btnUpload;
        private CustomControls.CustomButton btnNext;
    }
}

