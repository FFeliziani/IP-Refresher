using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TrayApp
{
    partial class ConfigWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new Panel();
            this.button2 = new Button();
            this.button1 = new Button();
            this.NetworkDescriptionLabel = new Label();
            this.NetworkIPLabel = new Label();
            this.OVHDescriptionLabel = new Label();
            this.OVHIpLabel = new Label();
            this.StatusLabel = new Label();
            this.NotRunningLinkLabel = new LinkLabel();
            this.RunningLinkLabel = new LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RunningLinkLabel);
            this.panel1.Controls.Add(this.NotRunningLinkLabel);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NetworkDescriptionLabel);
            this.panel1.Controls.Add(this.NetworkIPLabel);
            this.panel1.Controls.Add(this.OVHDescriptionLabel);
            this.panel1.Controls.Add(this.OVHIpLabel);
            this.panel1.Location = new Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(460, 187);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new Point(382, 161);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new Point(301, 161);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // NetworkDescriptionLabel
            // 
            this.NetworkDescriptionLabel.AutoSize = true;
            this.NetworkDescriptionLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.NetworkDescriptionLabel.Location = new Point(7, 65);
            this.NetworkDescriptionLabel.Name = "NetworkDescriptionLabel";
            this.NetworkDescriptionLabel.Size = new Size(105, 13);
            this.NetworkDescriptionLabel.TabIndex = 3;
            this.NetworkDescriptionLabel.Text = "Current Newtork IP";
            // 
            // NetworkIPLabel
            // 
            this.NetworkIPLabel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.NetworkIPLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Pixel, ((byte)(0)));
            this.NetworkIPLabel.Location = new Point(3, 78);
            this.NetworkIPLabel.Name = "NetworkIPLabel";
            this.NetworkIPLabel.Size = new Size(454, 41);
            this.NetworkIPLabel.TabIndex = 2;
            this.NetworkIPLabel.Text = "No IP, please refresh";
            this.NetworkIPLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OVHDescriptionLabel
            // 
            this.OVHDescriptionLabel.AutoSize = true;
            this.OVHDescriptionLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.OVHDescriptionLabel.Location = new Point(7, 7);
            this.OVHDescriptionLabel.Name = "OVHDescriptionLabel";
            this.OVHDescriptionLabel.Size = new Size(85, 13);
            this.OVHDescriptionLabel.TabIndex = 1;
            this.OVHDescriptionLabel.Text = "Current OVH IP";
            // 
            // OVHIpLabel
            // 
            this.OVHIpLabel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.OVHIpLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Pixel, ((byte)(0)));
            this.OVHIpLabel.Location = new Point(3, 20);
            this.OVHIpLabel.Name = "OVHIpLabel";
            this.OVHIpLabel.Size = new Size(454, 41);
            this.OVHIpLabel.TabIndex = 0;
            this.OVHIpLabel.Text = "No IP, please refresh";
            this.OVHIpLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new Point(3, 166);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new Size(42, 13);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status:";
            // 
            // NotRunningLinkLabel
            // 
            this.NotRunningLinkLabel.AutoSize = true;
            this.NotRunningLinkLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.NotRunningLinkLabel.LinkColor = Color.Red;
            this.NotRunningLinkLabel.Location = new Point(51, 166);
            this.NotRunningLinkLabel.Name = "NotRunningLinkLabel";
            this.NotRunningLinkLabel.Size = new Size(74, 13);
            this.NotRunningLinkLabel.TabIndex = 7;
            this.NotRunningLinkLabel.TabStop = true;
            this.NotRunningLinkLabel.Text = "Not Running";
            this.NotRunningLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.NotRunningLinkLabel_LinkClicked);
            // 
            // RunningLinkLabel
            // 
            this.RunningLinkLabel.AutoSize = true;
            this.RunningLinkLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.RunningLinkLabel.LinkColor = Color.Green;
            this.RunningLinkLabel.Location = new Point(51, 166);
            this.RunningLinkLabel.Name = "RunningLinkLabel";
            this.RunningLinkLabel.Size = new Size(52, 13);
            this.RunningLinkLabel.TabIndex = 8;
            this.RunningLinkLabel.TabStop = true;
            this.RunningLinkLabel.Text = "Running";
            this.RunningLinkLabel.Visible = false;
            this.RunningLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.RunningLinkLabel_LinkClicked);
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(484, 211);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigWindow";
            this.Text = "ConfigWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label OVHDescriptionLabel;
        private Label OVHIpLabel;
        private Label NetworkDescriptionLabel;
        private Label NetworkIPLabel;
        private Button button2;
        private Button button1;
        private LinkLabel NotRunningLinkLabel;
        private Label StatusLabel;
        private LinkLabel RunningLinkLabel;
    }
}

