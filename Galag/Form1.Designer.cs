namespace Galag
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayerPB = new System.Windows.Forms.PictureBox();
            this.BulletPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPB
            // 
            this.PlayerPB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayerPB.Image = ((System.Drawing.Image)(resources.GetObject("PlayerPB.Image")));
            this.PlayerPB.Location = new System.Drawing.Point(147, 504);
            this.PlayerPB.Name = "PlayerPB";
            this.PlayerPB.Size = new System.Drawing.Size(48, 48);
            this.PlayerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerPB.TabIndex = 0;
            this.PlayerPB.TabStop = false;
            // 
            // BulletPB
            // 
            this.BulletPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BulletPB.BackgroundImage")));
            this.BulletPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BulletPB.Location = new System.Drawing.Point(162, 478);
            this.BulletPB.Name = "BulletPB";
            this.BulletPB.Size = new System.Drawing.Size(20, 20);
            this.BulletPB.TabIndex = 1;
            this.BulletPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(332, 553);
            this.Controls.Add(this.BulletPB);
            this.Controls.Add(this.PlayerPB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerPB;
        private System.Windows.Forms.PictureBox BulletPB;
    }
}

