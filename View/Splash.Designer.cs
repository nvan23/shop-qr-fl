
namespace shop_qr.View
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.progressSplash = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Interval = 200;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // progressSplash
            // 
            this.progressSplash.AllowAnimations = false;
            this.progressSplash.Animation = 0;
            this.progressSplash.AnimationSpeed = 20;
            this.progressSplash.AnimationStep = 10;
            this.progressSplash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressSplash.BackgroundImage")));
            this.progressSplash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressSplash.BorderRadius = 9;
            this.progressSplash.BorderThickness = 1;
            this.progressSplash.Location = new System.Drawing.Point(108, 346);
            this.progressSplash.Maximum = 110;
            this.progressSplash.MaximumValue = 110;
            this.progressSplash.Minimum = 0;
            this.progressSplash.MinimumValue = 0;
            this.progressSplash.Name = "progressSplash";
            this.progressSplash.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressSplash.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressSplash.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.progressSplash.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.progressSplash.Size = new System.Drawing.Size(389, 13);
            this.progressSplash.TabIndex = 0;
            this.progressSplash.Value = 10;
            this.progressSplash.ValueByTransition = 10;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(598, 371);
            this.Controls.Add(this.progressSplash);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuProgressBar progressSplash;
        public System.Windows.Forms.Timer timerSplash;
    }
}