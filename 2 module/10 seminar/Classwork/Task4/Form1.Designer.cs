
namespace Task4
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
            this.labelHits = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.labelFail = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHits
            // 
            this.labelHits.AutoSize = true;
            this.labelHits.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHits.ForeColor = System.Drawing.Color.Lime;
            this.labelHits.Location = new System.Drawing.Point(285, 253);
            this.labelHits.Name = "labelHits";
            this.labelHits.Size = new System.Drawing.Size(0, 70);
            this.labelHits.TabIndex = 0;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Aqua;
            this.button.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.Color.MediumBlue;
            this.button.Location = new System.Drawing.Point(142, 133);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(107, 92);
            this.button.TabIndex = 2;
            this.button.Text = "Click Me!";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFail.ForeColor = System.Drawing.Color.Red;
            this.labelFail.Location = new System.Drawing.Point(43, 253);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(0, 70);
            this.labelFail.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Игрок 1",
            "Игрок 2"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(385, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonResult
            // 
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonResult.Location = new System.Drawing.Point(0, 315);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(385, 38);
            this.buttonResult.TabIndex = 5;
            this.buttonResult.Text = "Результат";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 353);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelHits);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHits;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonResult;
    }
}

