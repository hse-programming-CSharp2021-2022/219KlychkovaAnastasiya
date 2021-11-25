
namespace Cat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CatLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.invisibleTimer = new System.Windows.Forms.Timer(this.components);
            this.visibleTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CatLabel
            // 
            this.CatLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatLabel.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.CatLabel.Location = new System.Drawing.Point(0, 0);
            this.CatLabel.Name = "CatLabel";
            this.CatLabel.Size = new System.Drawing.Size(895, 176);
            this.CatLabel.TabIndex = 0;
            this.CatLabel.Text = "Cheshire Cat";
            this.CatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 650;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // invisibleTimer
            // 
            this.invisibleTimer.Tick += new System.EventHandler(this.invisibleTimer_Tick);
            // 
            // visibleTimer
            // 
            this.visibleTimer.Tick += new System.EventHandler(this.visibleTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 176);
            this.Controls.Add(this.CatLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Растаявшая надпись";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CatLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer invisibleTimer;
        private System.Windows.Forms.Timer visibleTimer;
    }
}

