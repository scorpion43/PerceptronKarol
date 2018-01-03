namespace WindowsFormsApp1.Service.Implement
{
    partial class ValueFormView
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.variableH = new System.Windows.Forms.TextBox();
            this.variableZ = new System.Windows.Forms.TextBox();
            this.variableY = new System.Windows.Forms.TextBox();
            this.variableX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataSetSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EpochsText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxErrorText = new System.Windows.Forms.TextBox();
            this.sd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Zo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Xo";
            // 
            // variableH
            // 
            this.variableH.Location = new System.Drawing.Point(41, 113);
            this.variableH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.variableH.Name = "variableH";
            this.variableH.Size = new System.Drawing.Size(132, 22);
            this.variableH.TabIndex = 18;
            this.variableH.Text = "0,1";
            this.variableH.TextChanged += new System.EventHandler(this.variableH_TextChanged);
            // 
            // variableZ
            // 
            this.variableZ.Location = new System.Drawing.Point(41, 81);
            this.variableZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.variableZ.Name = "variableZ";
            this.variableZ.Size = new System.Drawing.Size(132, 22);
            this.variableZ.TabIndex = 17;
            this.variableZ.Text = "1";
            // 
            // variableY
            // 
            this.variableY.Location = new System.Drawing.Point(41, 49);
            this.variableY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.variableY.Name = "variableY";
            this.variableY.Size = new System.Drawing.Size(132, 22);
            this.variableY.TabIndex = 16;
            this.variableY.Text = "1";
            // 
            // variableX
            // 
            this.variableX.Location = new System.Drawing.Point(41, 17);
            this.variableX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.variableX.Name = "variableX";
            this.variableX.Size = new System.Drawing.Size(132, 22);
            this.variableX.TabIndex = 15;
            this.variableX.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.variableZ);
            this.panel1.Controls.Add(this.variableX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.variableY);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.variableH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 158);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataSetSize);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.EpochsText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.MaxErrorText);
            this.panel2.Controls.Add(this.sd);
            this.panel2.Location = new System.Drawing.Point(203, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 158);
            this.panel2.TabIndex = 24;
            // 
            // DataSetSize
            // 
            this.DataSetSize.Location = new System.Drawing.Point(65, 129);
            this.DataSetSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataSetSize.Name = "DataSetSize";
            this.DataSetSize.Size = new System.Drawing.Size(132, 22);
            this.DataSetSize.TabIndex = 28;
            this.DataSetSize.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "DataSetSize";
            // 
            // EpochsText
            // 
            this.EpochsText.Location = new System.Drawing.Point(65, 76);
            this.EpochsText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EpochsText.Name = "EpochsText";
            this.EpochsText.Size = new System.Drawing.Size(132, 22);
            this.EpochsText.TabIndex = 26;
            this.EpochsText.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Epochs";
            // 
            // MaxErrorText
            // 
            this.MaxErrorText.Location = new System.Drawing.Point(65, 21);
            this.MaxErrorText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxErrorText.Name = "MaxErrorText";
            this.MaxErrorText.Size = new System.Drawing.Size(132, 22);
            this.MaxErrorText.TabIndex = 24;
            this.MaxErrorText.Text = "0,00001";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(105, 1);
            this.sd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(65, 17);
            this.sd.TabIndex = 23;
            this.sd.Text = "MaxError";
            // 
            // ValueFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 187);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ValueFormView";
            this.Text = "ValueFormView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox variableH;
        private System.Windows.Forms.TextBox variableZ;
        private System.Windows.Forms.TextBox variableY;
        private System.Windows.Forms.TextBox variableX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox EpochsText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaxErrorText;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.TextBox DataSetSize;
        private System.Windows.Forms.Label label6;
    }
}