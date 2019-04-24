﻿namespace Sonic_06_Toolkit
{
    partial class Logo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logo));
            this.pnl_Backdrop = new System.Windows.Forms.Panel();
            this.btn_SaveToDisk = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Credit = new System.Windows.Forms.Label();
            this.sfd_SaveLogo = new System.Windows.Forms.SaveFileDialog();
            this.pnl_Backdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Backdrop
            // 
            this.pnl_Backdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Backdrop.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Backdrop.Controls.Add(this.btn_SaveToDisk);
            this.pnl_Backdrop.Location = new System.Drawing.Point(0, 408);
            this.pnl_Backdrop.Name = "pnl_Backdrop";
            this.pnl_Backdrop.Size = new System.Drawing.Size(494, 31);
            this.pnl_Backdrop.TabIndex = 8;
            // 
            // btn_SaveToDisk
            // 
            this.btn_SaveToDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveToDisk.BackColor = System.Drawing.Color.LightGreen;
            this.btn_SaveToDisk.FlatAppearance.BorderSize = 0;
            this.btn_SaveToDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveToDisk.Location = new System.Drawing.Point(4, 4);
            this.btn_SaveToDisk.Name = "btn_SaveToDisk";
            this.btn_SaveToDisk.Size = new System.Drawing.Size(486, 23);
            this.btn_SaveToDisk.TabIndex = 0;
            this.btn_SaveToDisk.Text = "Save to disk";
            this.btn_SaveToDisk.UseVisualStyleBackColor = false;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Logo.BackgroundImage = global::Sonic_06_Toolkit.Properties.Resources.logo_main;
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(494, 410);
            this.pic_Logo.TabIndex = 7;
            this.pic_Logo.TabStop = false;
            // 
            // lbl_Credit
            // 
            this.lbl_Credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Credit.AutoSize = true;
            this.lbl_Credit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Credit.Location = new System.Drawing.Point(345, 9);
            this.lbl_Credit.Name = "lbl_Credit";
            this.lbl_Credit.Size = new System.Drawing.Size(142, 21);
            this.lbl_Credit.TabIndex = 9;
            this.lbl_Credit.Text = "Designed by Hyper";
            this.lbl_Credit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sfd_SaveLogo
            // 
            this.sfd_SaveLogo.Filter = "PNG|*.png";
            this.sfd_SaveLogo.Title = "Save As";
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(494, 439);
            this.Controls.Add(this.pnl_Backdrop);
            this.Controls.Add(this.lbl_Credit);
            this.Controls.Add(this.pic_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(510, 478);
            this.Name = "Logo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logo";
            this.pnl_Backdrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Backdrop;
        private System.Windows.Forms.Button btn_SaveToDisk;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label lbl_Credit;
        private System.Windows.Forms.SaveFileDialog sfd_SaveLogo;
    }
}