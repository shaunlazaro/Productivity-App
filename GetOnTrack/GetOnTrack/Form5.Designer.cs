namespace GetOnTrack
{
    partial class Form5
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
            this.NewTaskBox = new System.Windows.Forms.TextBox();
            this.instructionButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.infoUseless = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumberOnList = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Lister";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add To List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewTaskBox
            // 
            this.NewTaskBox.Location = new System.Drawing.Point(22, 349);
            this.NewTaskBox.Name = "NewTaskBox";
            this.NewTaskBox.Size = new System.Drawing.Size(157, 20);
            this.NewTaskBox.TabIndex = 4;
            this.NewTaskBox.Text = "Finish Homework";
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.Color.Transparent;
            this.instructionButton.Location = new System.Drawing.Point(840, 38);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(132, 23);
            this.instructionButton.TabIndex = 24;
            this.instructionButton.Text = "Show Instructions";
            this.instructionButton.UseVisualStyleBackColor = false;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.Location = new System.Drawing.Point(840, 9);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(132, 23);
            this.backbutton.TabIndex = 25;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // infoUseless
            // 
            this.infoUseless.AutoSize = true;
            this.infoUseless.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUseless.Location = new System.Drawing.Point(407, 24);
            this.infoUseless.Name = "infoUseless";
            this.infoUseless.Size = new System.Drawing.Size(152, 36);
            this.infoUseless.TabIndex = 26;
            this.infoUseless.Text = "To-Do List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 392);
            this.label2.TabIndex = 27;
            this.label2.Text = "1:\r\n2:\r\n3:\r\n4:\r\n5:\r\n6:\r\n7:\r\n8:\r\n9:\r\n10:\r\n11:\r\n12:\r\n13:\r\n14:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(277, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 419);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // NumberOnList
            // 
            this.NumberOnList.Location = new System.Drawing.Point(22, 323);
            this.NumberOnList.Name = "NumberOnList";
            this.NumberOnList.Size = new System.Drawing.Size(157, 20);
            this.NumberOnList.TabIndex = 31;
            this.NumberOnList.Text = "1";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(18, 152);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(247, 168);
            this.instructionLabel.TabIndex = 32;
            this.instructionLabel.Text = "Enter a number between \r\n1 and 14 in the top label\r\nThen enter a task in the \r\nbo" +
    "ttom label.\r\nEnter nothing or \"Done\" in \r\nthe bottom label to\r\nremove the task.";
            this.instructionLabel.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.NumberOnList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoUseless);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.NewTaskBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Ontrack Lister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NewTaskBox;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label infoUseless;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumberOnList;
        private System.Windows.Forms.Label instructionLabel;
    }
}