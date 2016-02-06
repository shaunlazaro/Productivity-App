namespace GetOnTrack
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.instructionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lister";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 140);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 140);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 140);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 140);
            this.button4.TabIndex = 5;
            this.button4.Text = "Save 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 140);
            this.button5.TabIndex = 6;
            this.button5.Text = "Save 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(597, 317);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 140);
            this.button6.TabIndex = 7;
            this.button6.Text = "Save 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.Color.Transparent;
            this.instructionButton.Location = new System.Drawing.Point(840, 12);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(132, 23);
            this.instructionButton.TabIndex = 23;
            this.instructionButton.Text = "Back";
            this.instructionButton.UseVisualStyleBackColor = false;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form3";
            this.Text = "Ontrack Lister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button instructionButton;
    }
}