
namespace Task3
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
            this.buttonSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSize
            // 
            this.buttonSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSize.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSize.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonSize.ForeColor = System.Drawing.Color.Sienna;
            this.buttonSize.Location = new System.Drawing.Point(31, 12);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(197, 75);
            this.buttonSize.TabIndex = 0;
            this.buttonSize.Text = "Уменьшить форму";
            this.buttonSize.UseVisualStyleBackColor = false;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 105);
            this.Controls.Add(this.buttonSize);
            this.MaximumSize = new System.Drawing.Size(548, 548);
            this.MinimumSize = new System.Drawing.Size(287, 161);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение размеров формы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSize;
    }
}

