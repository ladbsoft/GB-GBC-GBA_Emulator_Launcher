namespace Gb_Gbc_Gba_Emulator_Launcher
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtDefaultEmulatorPath = new System.Windows.Forms.TextBox();
            this.btnDefaultEmulatorPathChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.Location = new System.Drawing.Point(19, 16);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(376, 113);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = resources.GetString("lblWarning.Text");
            // 
            // txtDefaultEmulatorPath
            // 
            this.txtDefaultEmulatorPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultEmulatorPath.Location = new System.Drawing.Point(19, 132);
            this.txtDefaultEmulatorPath.Name = "txtDefaultEmulatorPath";
            this.txtDefaultEmulatorPath.Size = new System.Drawing.Size(341, 20);
            this.txtDefaultEmulatorPath.TabIndex = 1;
            // 
            // btnDefaultEmulatorPathChoose
            // 
            this.btnDefaultEmulatorPathChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultEmulatorPathChoose.Location = new System.Drawing.Point(365, 130);
            this.btnDefaultEmulatorPathChoose.Name = "btnDefaultEmulatorPathChoose";
            this.btnDefaultEmulatorPathChoose.Size = new System.Drawing.Size(29, 23);
            this.btnDefaultEmulatorPathChoose.TabIndex = 2;
            this.btnDefaultEmulatorPathChoose.Text = "...";
            this.btnDefaultEmulatorPathChoose.UseVisualStyleBackColor = true;
            this.btnDefaultEmulatorPathChoose.Click += new System.EventHandler(this.btnDefaultEmulatorPathChoose_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 171);
            this.Controls.Add(this.btnDefaultEmulatorPathChoose);
            this.Controls.Add(this.txtDefaultEmulatorPath);
            this.Controls.Add(this.lblWarning);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "GB/GBC/GBA Emulator Launcher - Configuración";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtDefaultEmulatorPath;
        private System.Windows.Forms.Button btnDefaultEmulatorPathChoose;
    }
}