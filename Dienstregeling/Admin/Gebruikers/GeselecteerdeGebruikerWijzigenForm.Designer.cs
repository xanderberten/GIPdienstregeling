﻿namespace Dienstregeling
{
    partial class GeselecteerdeGebruikerWijzigenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeselecteerdeGebruikerWijzigenForm));
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(184, 6);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(201, 20);
            this.gebruikersnaamTextBox.TabIndex = 0;
            this.gebruikersnaamTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gebruikersnaamTextBox_Validating);
            this.gebruikersnaamTextBox.Validated += new System.EventHandler(this.gebruikersnaamTextBox_Validated);
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(15, 51);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(370, 23);
            this.opslaanButton.TabIndex = 3;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam";
            // 
            // GeselecteerdeGebruikerWijzigenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeselecteerdeGebruikerWijzigenForm";
            this.Text = "NMBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Label label1;
    }
}