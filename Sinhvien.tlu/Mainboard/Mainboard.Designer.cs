

namespace Sinhvien.tlu.Mainboard
{
    partial class System_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Main));
            SuspendLayout();
            // 
            // System_Main
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1904, 1040);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1079);
            MinimumSize = new Size(1918, 1038);
            Name = "System_Main";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Education | Trang chủ";
            WindowState = FormWindowState.Maximized;
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit_Program);
            ResumeLayout(false);
        }

        #endregion
    }
}