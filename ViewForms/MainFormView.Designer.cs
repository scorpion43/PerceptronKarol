namespace WindowsFormsApp1.Service.Implement
{
    partial class MainFormView
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
            this.ListBoxVariableX = new System.Windows.Forms.ListBox();
            this.ListBoxVariableY = new System.Windows.Forms.ListBox();
            this.ListBoxVariableZ = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.listBoxOutputX = new System.Windows.Forms.ListBox();
            this.listBoxOutputY = new System.Windows.Forms.ListBox();
            this.listBoxOutputZ = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxVariableX
            // 
            this.ListBoxVariableX.FormattingEnabled = true;
            this.ListBoxVariableX.Location = new System.Drawing.Point(3, 3);
            this.ListBoxVariableX.Name = "ListBoxVariableX";
            this.ListBoxVariableX.Size = new System.Drawing.Size(100, 238);
            this.ListBoxVariableX.TabIndex = 8;
            // 
            // ListBoxVariableY
            // 
            this.ListBoxVariableY.FormattingEnabled = true;
            this.ListBoxVariableY.Location = new System.Drawing.Point(3, 3);
            this.ListBoxVariableY.Name = "ListBoxVariableY";
            this.ListBoxVariableY.Size = new System.Drawing.Size(100, 238);
            this.ListBoxVariableY.TabIndex = 9;
            // 
            // ListBoxVariableZ
            // 
            this.ListBoxVariableZ.FormattingEnabled = true;
            this.ListBoxVariableZ.Location = new System.Drawing.Point(3, 3);
            this.ListBoxVariableZ.Name = "ListBoxVariableZ";
            this.ListBoxVariableZ.Size = new System.Drawing.Size(100, 238);
            this.ListBoxVariableZ.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Output X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Output Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Output Z";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 13);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(123, 95);
            this.GenerateButton.TabIndex = 24;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(12, 114);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(123, 95);
            this.learnButton.TabIndex = 25;
            this.learnButton.Text = "Start Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 215);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(123, 95);
            this.showButton.TabIndex = 26;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // listBoxOutputX
            // 
            this.listBoxOutputX.FormattingEnabled = true;
            this.listBoxOutputX.Location = new System.Drawing.Point(106, 3);
            this.listBoxOutputX.Name = "listBoxOutputX";
            this.listBoxOutputX.Size = new System.Drawing.Size(100, 238);
            this.listBoxOutputX.TabIndex = 27;
            // 
            // listBoxOutputY
            // 
            this.listBoxOutputY.FormattingEnabled = true;
            this.listBoxOutputY.Location = new System.Drawing.Point(106, 3);
            this.listBoxOutputY.Name = "listBoxOutputY";
            this.listBoxOutputY.Size = new System.Drawing.Size(100, 238);
            this.listBoxOutputY.TabIndex = 28;
            // 
            // listBoxOutputZ
            // 
            this.listBoxOutputZ.FormattingEnabled = true;
            this.listBoxOutputZ.Location = new System.Drawing.Point(106, 3);
            this.listBoxOutputZ.Name = "listBoxOutputZ";
            this.listBoxOutputZ.Size = new System.Drawing.Size(100, 238);
            this.listBoxOutputZ.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxVariableX);
            this.panel1.Controls.Add(this.listBoxOutputX);
            this.panel1.Location = new System.Drawing.Point(141, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 244);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxOutputY);
            this.panel2.Controls.Add(this.ListBoxVariableY);
            this.panel2.Location = new System.Drawing.Point(356, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 244);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBoxOutputZ);
            this.panel3.Controls.Add(this.ListBoxVariableZ);
            this.panel3.Location = new System.Drawing.Point(568, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 244);
            this.panel3.TabIndex = 32;
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 341);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.learnButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "MainFormView";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBoxVariableX;
        private System.Windows.Forms.ListBox ListBoxVariableY;
        private System.Windows.Forms.ListBox ListBoxVariableZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox listBoxOutputX;
        private System.Windows.Forms.ListBox listBoxOutputY;
        private System.Windows.Forms.ListBox listBoxOutputZ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

