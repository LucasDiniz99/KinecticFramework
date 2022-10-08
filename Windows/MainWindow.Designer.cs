namespace KinecticFramework.Windows
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LoadingIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingIcon
            // 
            this.LoadingIcon.Image = ((System.Drawing.Image)(resources.GetObject("LoadingIcon.Image")));
            this.LoadingIcon.Location = new System.Drawing.Point(420, 200);
            this.LoadingIcon.Name = "LoadingIcon";
            this.LoadingIcon.Size = new System.Drawing.Size(120, 120);
            this.LoadingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingIcon.TabIndex = 0;
            this.LoadingIcon.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.LoadingIcon);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox LoadingIcon;
    }
}