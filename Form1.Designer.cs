namespace bapp
{
    partial class bapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bapp));
            this.scanApp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scanApp
            // 
            this.scanApp.Enabled = true;
            this.scanApp.Interval = 1000;
            this.scanApp.Tick += new System.EventHandler(this.scanApp_Tick);
            // 
            // bapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 202);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bapp";
            this.Text = "Windowsx64";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer scanApp;
    }
}

